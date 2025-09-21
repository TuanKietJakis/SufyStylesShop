using BussinessObject.DTO;
using BussinessObject.DTO.User;
using BussinessObject.Model;
using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface IUserRepository 
    {
        Task<bool> ClientRegister(User registerAccount);
        Task<bool> EmailExist(string mail); 
        Task<bool> PhoneExist(string phone);

        Task<User> GetProfile(Guid userId);

        Task<UserFollow?> GetFollow(Guid followerId, Guid followingId);

        Task AddFollow(UserFollow follow);

        Task UpdateFollow(UserFollow follow);
    
        Task<User?> GetUserByEmail(string email);
        Task<User?> GetEmailByPhone(string phoneNumber);
        Task UpdateUser(User user);
        Task<User> GetUserById(Guid userId);
        
        Task AddAddress(UserAddress address);

        Task<IEnumerable<UserAddress>> GetAddressesByUserId(Guid userId);
        Task<UserAddress?> GetAddressById(Guid addressId);
        Task UpdateAddress(UserAddress address);
        Task<bool> IsUsernameExists(string username);     
    }
}
