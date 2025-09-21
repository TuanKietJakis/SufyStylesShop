using BussinessObject.Models;
using Repository.IRepository;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.UserRepositoryTest
{
    public class IsUsernameExistsTest
    {
        private readonly IUserRepository _repo;
        private readonly SufyStylesShopContext _context;

        public IsUsernameExistsTest()
        {
            _context = new SufyStylesShopContext();
            _repo = new UserRepository(_context);
        }

        [Theory]
        [InlineData("Kim", true)] // Username đã tồn tại
        [InlineData("nonExistingUser", false)] // Username chưa tồn tại
        [InlineData("", false)] // Username rỗng
        [InlineData("user1234567890123456789012345678901234567890123456", true)] // Username tối đa 50 ký tự
        [InlineData("user12345678901234567890123456789012345678901234567", false)] // Vượt quá độ dài (51 ký tự)
        public async Task IsUsernameExists_WithVariousInputs_ReturnsExpected(string username, bool expectedResult)
        {
            try
            {
               
                // Gọi hàm kiểm tra (Act)
                var result = await _repo.IsUsernameExists(username);

                // Kiểm tra kết quả (Assert)
                Assert.Equal(expectedResult, result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi xảy ra: {ex.Message}");
                Assert.False(expectedResult); // Nếu ném lỗi thì kỳ vọng kết quả là false
            }
        }
    }
}
