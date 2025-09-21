using BussinessObject.DTO.User;
using BussinessObject.DTO;
using Microsoft.AspNetCore.Mvc;

using Repository.IRepository;
using ISUZU_NEXT.Server.Core.Extentions;
using BussinessObject.Models;
using BussinessObject.Model;
using Microsoft.EntityFrameworkCore;
using Repositories.IRepository;
using Repositories.Repository;
using BussinessObject.DTO.UserVoucher;
using System.Text.RegularExpressions;
using APIService.Extension;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace APIService.Service
{
    public class UserService
    {
        private readonly IUserVoucherRepository _userVoucherRepository;
        private readonly IUserRepository _userRepository;
  
   
        public UserService(IUserRepository userRepository, IUserVoucherRepository userVoucherRepository)
        {
            _userRepository = userRepository;
         
            _userVoucherRepository = userVoucherRepository;
        }
        public async Task<PaginatedResponse<UserVoucherDto>> ShowUserVouchers(Guid userId,UserVoucherPaginationParams paginationParams)
        {
            var entityPages = await _userVoucherRepository.GetPaginatedListUser(userId,paginationParams);
            var dtoPages = new PaginatedResponse<UserVoucherDto>();
            dtoPages.CopyProperties(entityPages);
            return dtoPages;
        }

        public async Task<bool> Register(RegisterAccountModel userRegisterDto)
        {
            var mail = await CheckMail(userRegisterDto.Email);
            if(mail == true) { throw new Exception("Invalid Email Address!\r\nA valid email address is one that has not been previously registered in the system, follows the correct format (e.g., example@gmail.com), and does not exceed 50 characters in length."); }
            var phone = await _userRepository.PhoneExist(userRegisterDto.Phone);
            if (phone == true) return false;

            if (await _userRepository.IsUsernameExists(userRegisterDto.Username))
            {
                do
                {
                    userRegisterDto.Username = userRegisterDto.Email.Split('@')[0] + Guid.NewGuid().ToString("N").Substring(0, 8);
                }
                while (await _userRepository.IsUsernameExists(userRegisterDto.Username));
            }


            var newUser = new User();
            newUser.CopyProperties(userRegisterDto);
            string hashedPassword = PasswordHasher.HashPassword(userRegisterDto.Password);

            Console.WriteLine("PassRegister  " + hashedPassword);

            newUser.Password = hashedPassword;
            newUser.CreatedDate = DateTime.UtcNow;
           
            newUser.IsBanned = false;
            newUser.RoleId = new Guid("C3D4E5F6-A7B8-4901-CDEF-34567890ABCD");

            return await _userRepository.ClientRegister(newUser);
        }

        public async Task<bool> CheckMail(string mail)
        {
            var checkMail = await _userRepository.EmailExist(mail);
            if(!checkMail) return false;
            return true;
        }


        public async Task<UserDto?> GetProfile(Guid userId)
        {
            var user = await _userRepository.GetProfile(userId);

            if (user == null)
            {
                return null;
            }

            var userDto = new UserDto();
          
            userDto.CopyProperties(user);

            userDto.LastName = user.Lastname;
            userDto.FirstName = user.Firstname;
            userDto.Following = user.Followers
                .Where(f => f.FollowingId == userId && !f.IsDeleted) 
                .Select(f => new FollowDto
                {
                    UserId = f.FollowerId, 
                    Username = f.FollowerUser?.Username,
                    ProfileName = f.FollowerUser?.ProfileName,
                    UrlImage = f.FollowerUser?.UrlImage,
                    FollowDate = f.FollowDate,
                   
                    IsDeleted = f.IsDeleted
                }).ToList();

            userDto.Followers = user.Following
                .Where(f => f.FollowerId == userId && !f.IsDeleted) 
                .Select(f => new FollowDto
                {
                    UserId = f.FollowingId, 
                    Username = f.FollowingUser?.Username,
                    ProfileName = f.FollowingUser?.ProfileName,
                    UrlImage = f.FollowingUser?.UrlImage,
                    FollowDate = f.FollowDate,
                   
                    IsDeleted = f.IsDeleted
                }).ToList();

            return userDto;
        }

        
        public async Task<ActionResult> EditProfile(UserEditDto userEditDto)
        {
            var existingUser = await _userRepository.GetUserById(userEditDto.UserId);
            if (existingUser == null)
            {
                return new NotFoundObjectResult(new { message = "User not found. Please check the user ID." });
            }

            if (!string.IsNullOrEmpty(userEditDto.Username))
            {
                var usernameExists = await _userRepository.IsUsernameExists(userEditDto.Username);
                if (usernameExists)
                {
                    return new BadRequestObjectResult(new { message = "Username is already taken. Please choose a different one." });
                }
            }

            existingUser.CopyProperties(userEditDto);
            existingUser.UpdatedDate = DateTime.UtcNow;

            await _userRepository.UpdateUser(existingUser);
            return new OkObjectResult(new { message = "User updated successfully." });
        }


        public async Task<bool> Follow(Guid followerId, Guid followingId)
        {
            if (followerId == followingId)
                return false;

            var existingFollow = await _userRepository.GetFollow(followerId, followingId);

            if (existingFollow != null)
            {
                if (existingFollow.IsDeleted)
                {
                    existingFollow.IsDeleted = false;
                    existingFollow.FollowDate = DateTime.UtcNow;
                    await _userRepository.UpdateFollow(existingFollow);

                    return true;
                }
                return false;
            }

            var follow = new UserFollow
            {
                FollowerId = followerId,
                FollowingId = followingId,
                FollowDate = DateTime.UtcNow,
                
            };

            await _userRepository.AddFollow(follow);
            return true;
        }

        public async Task<bool> Unfollow(Guid followerId, Guid followingId)
        {
            if (followerId == followingId)
                return false;

            var follow = await _userRepository.GetFollow(followerId, followingId);
            if (follow == null || follow.IsDeleted)
                return false;

            follow.IsDeleted = true;
            await  _userRepository.UpdateFollow(follow);      
            return true;
        }
        public async Task<bool> ResetPassword(string email, string newPassword)
        {
           
            var user = await _userRepository.GetUserByEmail(email);
           
            string hashedPassword = PasswordHasher.HashPassword(newPassword);
            user.Password = hashedPassword;
            user.UpdatedDate = DateTime.UtcNow;
            user.IsAcceptMarketing = true;
            await _userRepository.UpdateUser(user);
            return true;
        }

        public async Task<string> ChangePassword(Guid userId, string oldPassword, string newPassword)
        {
            var user = await _userRepository.GetUserById(userId);
            if (user == null)
            {
                return "User not found";
            }

            string hashedOldPassword = PasswordHasher.HashPassword(oldPassword);

            if (user.Password != hashedOldPassword)
            {
                return "Old password is incorrect";
            }

            string hashedNewPassword = PasswordHasher.HashPassword(newPassword);

            user.Password = hashedNewPassword;
            user.UpdatedDate = DateTime.UtcNow;

            await _userRepository.UpdateUser(user);
         
            return "Password changed successfully";
        }
       
        public async Task<List<AddressDto>> ShowAddressByUserId(Guid userId)
        {
            var addresses = await _userRepository.GetAddressesByUserId(userId);

            if (addresses == null || !addresses.Any())
            {
                return new List<AddressDto>(); 
            }

            var addressDtos = addresses.Select(address =>
            {
                var addressDto = new AddressDto();
                addressDto.CopyProperties(address);
                return addressDto;
            }).ToList();

            return addressDtos;
        }

        public async Task<bool> CreateAddressByUserId(Guid userId, AddressCreateEditDto addressDto)
        {
            var user = await _userRepository.GetUserById(userId);
            if (user == null)
            {
                return false; 
            }

            var newAddress = new UserAddress
            {
                AddressId = Guid.NewGuid(),
                UserId = userId,
                IsDeleted = false
            };

            newAddress.CopyProperties(addressDto);         
            await _userRepository.AddAddress(newAddress);
        
            return true; 
        }

        public async Task<bool> EditAddress(Guid userId, Guid addressId, AddressCreateEditDto addressDto)
        {
       
            var address = await _userRepository.GetAddressById(addressId);
         
            if (address == null || address.UserId != userId)
            {
                return false; 
            }

            address.AddressName = addressDto.AddressName ?? address.AddressName;
            address.Fullname = addressDto.Fullname ?? address.Fullname;
            address.Phone = addressDto.Phone ?? address.Phone;

            await _userRepository.UpdateAddress(address); 

            return true; 
        }
        public async Task<bool> DeleteAddress(Guid userId, Guid addressId)
        {         
            var address = await _userRepository.GetAddressById(addressId);

            if (address == null || address.UserId != userId)
            {
                return false;
            }

            address.IsDeleted = true;
            await _userRepository.UpdateAddress(address);  
            return true;
        }
        public async Task<string?> FindEmailByPhone(string phoneNumber)
        {
            var user = await _userRepository.GetEmailByPhone(phoneNumber);
            if (user?.Email == null)
            {
                return null;
            }

            var email = user.Email;
            var atIndex = email.IndexOf('@');

            if (atIndex <= 3)
            {
                return "***" + email.Substring(atIndex);
            }

            var visiblePart = email.Substring(0, atIndex - 3); 
            var maskedPart = "***"; 

            return visiblePart + maskedPart + email.Substring(atIndex);
        }

        
        public async Task BanUser(Guid id, bool isBan)
        {
            var user = await _userRepository.GetUserById(id);
            if (user == null)
            {
                throw new Exception("User not found");
            }

            user.IsBanned = isBan;
            await _userRepository.UpdateUser(user);
        } 
        public async Task DeleteUser(Guid id, bool isDelete)
        {
            var user = await _userRepository.GetUserById(id);
            if (user == null)
            {
                throw new Exception("User not found");
            }

            user.IsDeleted = isDelete;
            await _userRepository.UpdateUser(user);
        }


    }
}

