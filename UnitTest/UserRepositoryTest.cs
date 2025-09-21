using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using Repository.IRepository;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class UserRepositoryTest1
    {
        private readonly IUserRepository _repo;
        private readonly SufyStylesShopContext _context;

        public UserRepositoryTest1()
        {
            _context = new SufyStylesShopContext(); // Real database context
            _repo = new UserRepository(_context);
        }


        [Fact]
        public async Task ClientRegister_WithValidUser_ReturnsTrue()
        {
            // Arrange
            var newUser = new User
            {
                UserId = Guid.NewGuid(),
                Username = "testuser",
                Password = "hashedpassword",
                Email = "test@example.com",
                Phone = "1234567890",
                RoleId = new Guid("C3D4E5F6-A7B8-4901-CDEF-34567890ABCD")
            };

            // Act
            var result = await _repo.ClientRegister(newUser);

            // Assert
            Assert.True(result);

            var userInDb = await _context.Users.FirstOrDefaultAsync(u => u.Username == "testuser");
            Assert.NotNull(userInDb);
            Assert.Equal("test@example.com", userInDb.Email);
        }

    }
}