using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepository
{
    public interface IAccountManageRepository 
    {
        Task<List<User>> GetUsersByRole(string role);
        Task<User?> GetUserById(Guid id);
        Task<List<User>> GetAll();
        Task Add(User user);
       
        Task<List<Role>> GetAllRoles();
        Task<Role?> GetRoleById(Guid roleId);
        Task UpdateUser(User user);
    }
}
