using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly SufyStylesShopContext _context;

        public AuthenticationRepository(SufyStylesShopContext context)
        {
            _context = context;
        }

     
        public async Task<User?> LoginUser(string email, string hashedPassword)
        {
            return await _context.Users
                .Include(a => a.Role)
                .FirstOrDefaultAsync(u => u.Email == email && u.Password == hashedPassword && !u.IsDeleted);
        }

        public async Task<User?> FindUserByEmail(string email)
        {
            return await _context.Users
                .Include(u => u.Role)
                .FirstOrDefaultAsync(u => u.Email == email && !u.IsDeleted);
        }
        public async Task<bool> IsUsernameExist(string username)
        {
            return await _context.Users.AnyAsync(u => u.Username == username);
        }

        public async Task<Guid> GetDefaultUserRoleId()
        {
            var defaultRole = await _context.Roles.FirstOrDefaultAsync(r => r.RoleName == "Customer");
            if (defaultRole == null)
            {
                throw new Exception("Default role 'User' not found.");
            }
            return defaultRole.RoleId;
        }

        public async Task CreateUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }
    }
}
