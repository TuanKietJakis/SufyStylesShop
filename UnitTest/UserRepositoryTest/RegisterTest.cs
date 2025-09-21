using System;
using System.Threading.Tasks;
using APIService.Extension;
using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using Repository.IRepository;
using Repository.Repository;
using Xunit;

namespace UnitTest.UserRepositoryTest
{
    public class UserRepositoryTest
    {
        private readonly IUserRepository _repo;
        private readonly SufyStylesShopContext _context;

        public UserRepositoryTest()
        {
           
            _context = new SufyStylesShopContext();
            _repo = new UserRepository(_context);
        }

        [Theory]
        [InlineData("user1", "test@example.com", "1234567890", true)] // Trường hợp hợp lệ
        public async Task ClientRegister_WithValidInputs_ReturnsTrue(string username, string email, string phone, bool expectedResult)
        {
            // Arrange
            var newUser = new User
            {
                UserId = Guid.NewGuid(),
                Username = username,
                Email = email,
                Phone = phone,
                RoleId = new Guid("C3D4E5F6-A7B8-4901-CDEF-34567890ABCD")
            };

            // Act
            var result = await _repo.ClientRegister(newUser);

            Console.WriteLine($"Test case: Username = {username}, Result = {result}");

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public async Task AddUser_InvalidDatabaseConnection_ShouldThrowException()
        {
            // Tạo một DbContext với chuỗi kết nối sai
            var options = new DbContextOptionsBuilder<SufyStylesShopContext>()
                .UseSqlServer("Server=invalid_server;Database=invalid_db;User Id=invalid_user;Password=invalid_pass;")
                .Options;

            var fakeContext = new SufyStylesShopContext(options);
            var fakeRepo = new UserRepository(fakeContext);

            var newUser = new User
            {
                UserId = Guid.NewGuid(),
                Username = "user1",
                Email = "test@example.com",
                Phone = "1234567890",
                RoleId = new Guid("C3D4E5F6-A7B8-4901-CDEF-34567890ABCD")
            };

            // Act & Assert
            await Assert.ThrowsAsync<DbUpdateException>(async () =>
            {
                await fakeRepo.ClientRegister(newUser);
            });
        }

    }
}
