using BussinessObject.Model;
using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using Repositories.Repository;
using Repository.IRepository;

namespace Repository.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly SufyStylesShopContext _context;

        public UserRepository(SufyStylesShopContext context) 
        {
            _context = context;
        }
      
    
        public async Task<bool> ClientRegister(User newUser)
        {
            try
            {
                await _context.Users.AddAsync(newUser);
                await _context.SaveChangesAsync();
                return true; 
            }
            catch (DbUpdateException ex) 
            {
                Console.WriteLine($"Error DB: {ex.InnerException?.Message}");
                return false; 
            }
        }


        public async Task<bool> EmailExist(string mail)
        {
            return await _context.Users.AnyAsync(c => c.Email == mail && c.IsDeleted == false);
        }


        public async Task<User?> GetProfile(Guid userId)
        {
            return await _context.Users
                .Include(u => u.Followers).ThenInclude(f => f.FollowerUser)
                .Include(u => u.Following).ThenInclude(f => f.FollowingUser)
                .FirstOrDefaultAsync(u => u.UserId == userId);
        }
      

        public async Task<UserFollow?> GetFollow(Guid followerId, Guid followingId)
        {
            return await _context.UserFollows
                .FirstOrDefaultAsync(f => f.FollowerId == followerId && f.FollowingId == followingId);
        }

        public async Task AddFollow(UserFollow follow)
        {
            await _context.UserFollows.AddAsync(follow);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateFollow(UserFollow follow)
        {
            _context.UserFollows.Update(follow);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUser(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User?> GetUserByEmail(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email && u.IsDeleted == false);
        }
        
        public async Task<User?> GetEmailByPhone(string phoneNumber)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Phone == phoneNumber && u.IsDeleted == false);
        }

        public async Task<User?> GetUserById(Guid userId)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.UserId == userId && u.IsDeleted == false);
        }
 
        public async Task<IEnumerable<UserAddress>> GetAddressesByUserId(Guid userId)
        {
            return await _context.UserAddresses
                                 .Where(a => a.UserId == userId)
                                 .ToListAsync();
        }

        public async Task AddAddress(UserAddress address)
        {
            await _context.UserAddresses.AddAsync(address);
            await _context.SaveChangesAsync();
        }

        public async Task<UserAddress?> GetAddressById(Guid addressId)
        {
           
            return await _context.UserAddresses
                       .Where(a => a.AddressId == addressId && !a.IsDeleted)
                       .FirstOrDefaultAsync();
        }

        public async Task UpdateAddress(UserAddress address)
        {
            _context.Update(address);
            await _context.SaveChangesAsync();
        }
        public async Task<bool> IsUsernameExists(string username)
        {
            return await _context.Users
                .AnyAsync(u => u.Username == username); 
        }

        public async Task<bool> PhoneExist(string phone)
        {
            return await _context.Users.AnyAsync(c => c.Phone == phone && c.IsDeleted == false);
        }
    }
}
