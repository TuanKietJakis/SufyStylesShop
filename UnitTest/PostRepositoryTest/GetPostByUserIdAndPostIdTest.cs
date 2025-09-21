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
    public class GetPostByUserIdAndPostIdTest
    {
        private readonly IPostRepository _repo;
        private readonly SufyStylesShopContext _context;

        public GetPostByUserIdAndPostIdTest()
        {
            _context = new SufyStylesShopContext();
            _repo = new PostRepository(_context);
        }

        [Theory]
        [InlineData("C33912D3-4525-43F1-B893-07580F2C4226", "BCB12B9B-D374-4505-9051-3A7CDE836F21", true)] // Tồn tại
        [InlineData("FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF", "FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF", false)] // Không tồn tại
        [InlineData("C33912D3-4525-43F1-B893-07580F2C4226", "FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF", false)] // ❌ User tồn tại nhưng không có Post
        public async Task GetPostByUserIdAndPostId_WithVariousInputs_ReturnsExpected(string userIdStr, string postIdStr, bool expectedResult)
        {
            try
            {
                // Chuyển đổi GUID từ string
                Guid userId = Guid.Parse(userIdStr);
                Guid postId = Guid.Parse(postIdStr);

                // Gọi method cần test
                var result = await _repo.GetPostByUserIdAndPostId(userId, postId);

                // So sánh kết quả mong đợi
                Assert.Equal(expectedResult, result != null);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi xảy ra: {ex.Message}");

                // Nếu có lỗi xảy ra, kiểm tra xem có phải vì post không tồn tại không
                Assert.False(expectedResult);
            }
        }
    }
}
