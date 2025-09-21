using APIService.Extension;
using BussinessObject.DTO.Admin;
using BussinessObject.DTO.User;
using BussinessObject.Models;
using ISUZU_NEXT.Server.Core.Extentions;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crypto.Generators;
using Repositories.IRepository;

namespace APIService.Service
{
    public class AccountManageService
    {
        private readonly IAccountManageRepository _adminRepository;

        public AccountManageService(IAccountManageRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public async Task<List<ShowUserForManageDto>> GetUsersByRole(string role)
        {          
            var users = await _adminRepository.GetUsersByRole(role);

            var userDtos = users.Select(u =>
            {
                var userDto = new ShowUserForManageDto();
                userDto.CopyProperties(u); 
                return userDto;
            }).ToList();

            return userDtos;
        }

        
        public async Task<List<ShowUserForManageDto>> GetAllUsers()
        {
            var users = await _adminRepository.GetAll();

            return users.Select(u =>
            {
                var dto = new ShowUserForManageDto();
                dto.CopyProperties(u);
                dto.RoleName = u.Role?.RoleName;
                return dto;
            }).ToList();
        }

        public async Task<List<Role>> GetAllRoles()
        {
            return await _adminRepository.GetAllRoles();
        }
        public async Task<bool> UpdateUserRole(Guid userId, Guid roleId)
        {
            var user = await _adminRepository.GetUserById(userId);
            if (user == null)
            {
                return false; // User không tồn tại
            }

            var role = await _adminRepository.GetRoleById(roleId);
            if (role == null)
            {
                return false; // Role không tồn tại
            }

            user.RoleId = roleId;
            user.UpdatedDate = DateTime.UtcNow;

            await _adminRepository.UpdateUser(user);
            return true;
        }
    }
}
