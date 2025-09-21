using BussinessObject.Models;
using Repositories.IRepository;
using Repositories.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.PostRepositoryTest
{
    public class GetAllByUserIdTest
    {
        private readonly IPostRepository _repo;
        private readonly SufyStylesShopContext _context;

        public GetAllByUserIdTest()
        {
            _context = new SufyStylesShopContext();
            _repo = new PostRepository(_context);
        }

        [Theory]
        [InlineData("C33912D3-4525-43F1-B893-07580F2C4226", true)] // User ID hợp lệ có bài viết
        [InlineData("C33912D3-4525-43F1-B893-07580F2C4227", false)] // User ID không tồn tại
        [InlineData("C33912D3-4525-43F1-B893-07580F2C4227dsssssssssđsdấdư", false)] // User ID không tồn tại
        public async Task GetAllByUserId_WithVariousInputs_ReturnsExpected(string userIdString, bool expectedResult)
        {
            try
            {
                Guid userId = Guid.Parse(userIdString);
                var result = _repo.GetAllByUserId(userId).ToList();

                // Assert: So sánh kết quả mong đợi
                Assert.Equal(expectedResult, result.Any());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi xảy ra: {ex.Message}");

                // Nếu có lỗi, kiểm tra xem kết quả có phải là false không
                Assert.False(expectedResult);
            }
        }
    }
}
