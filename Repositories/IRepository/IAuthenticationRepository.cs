using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepository
{
    public interface IAuthenticationRepository
    {
        Task<User?> LoginUser(string email, string hashedPassword);     
        Task<User?> FindUserByEmail(string email);
        Task<Guid> GetDefaultUserRoleId();
        Task CreateUser(User user);
        Task<bool> IsUsernameExist(string username);
       

    }
}
