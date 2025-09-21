using BussinessObject.DTO;
using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.IRepository;


namespace Repositories.Repository
{
    public class AccountManageRepository : IAccountManageRepository
    {
        private readonly SufyStylesShopContext _context;
        public AccountManageRepository(SufyStylesShopContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetUsersByRole(string role)
        {
            return await _context.Users
                .Where(u => u.Role.RoleName == role)  
                .ToListAsync();
        }
        public async Task<User?> GetUserById(Guid id)
        {
            return await _context.Users.Include(u => u.Role).FirstOrDefaultAsync(u => u.UserId == id);
        }

        public async Task<List<User>> GetAll()
        {
            return await _context.Users.Include(u => u.Role).ToListAsync();
        }

        public async Task Add(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

       
       
        public async Task<List<Role>> GetAllRoles()
        {
            return await _context.Roles.ToListAsync();
        }

        public async Task<Role?> GetRoleById(Guid roleId)
        {
            return await _context.Roles.FirstOrDefaultAsync(r => r.RoleId == roleId);
        }

        public async Task UpdateUser(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}
