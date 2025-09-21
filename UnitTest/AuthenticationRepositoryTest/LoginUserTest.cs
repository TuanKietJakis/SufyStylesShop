using APIService.Extension;
using BussinessObject.Models;
using Repositories.IRepository;
using Repositories.Repository;
using Repository.IRepository;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.AuthenticationRepositoryTest
{
    public class LoginUserTest
    {
        private readonly IAuthenticationRepository _repo;
        private readonly SufyStylesShopContext _context;

        public LoginUserTest()
        {
            _context = new SufyStylesShopContext();
            _repo = new AuthenticationRepository(_context);
        }

        [Theory]
        [InlineData("user1@example.com", "12345678aA@", true)]  // Đăng nhập thành công
        [InlineData("user1@example.com", "12345678aa@", false)]  // Sai mật khẩu
        [InlineData("notfound@example.com", "12345678aA@", false)] // Email không tồn tại
        
        [InlineData("notfound@example.com", "12345678aB@", false)] // Mail và pass sai
       
        public async Task LoginUser_WithVariousInputs_ReturnsExpected(string email, string password, bool expectedResult)
        {
            try
            {
                // Arrange: Hash mật khẩu
                string hashedPassword = PasswordHasher.HashPassword(password);

                // Act: Gọi phương thức LoginUser
                var result = await _repo.LoginUser(email, hashedPassword);

                // Console output giúp debug khi test chạy
                Console.WriteLine($"Test case: Email = {email}, Password = {password}, Result = {result != null}");

                // Assert: Kiểm tra kết quả có như mong đợi không
                Assert.Equal(expectedResult, result != null);
            }
            catch (Exception ex)
            {
                Assert.False(expectedResult, $"❌ Lỗi xảy ra: {ex.Message}");
            }
        }
    }
}
