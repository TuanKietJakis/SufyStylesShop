using BussinessObject.Models;
using Repositories.IRepository;
using Repositories.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.PostCommentRepositoryTest
{
    public class GetByIdAsyncTest
    {
        private readonly IPostCommentRepository _repo;
        private readonly SufyStylesShopContext _context;

        public GetByIdAsyncTest()
        {
            _context = new SufyStylesShopContext();
            _repo = new PostCommentRepository(_context);
        }

        [Theory]
        [InlineData("D1E2F3A4-B5C6-47D8-9ABC-1234567890AB", true)] // ID hợp lệ có trong DB
        [InlineData("FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF", false)] // ID không tồn tại
        [InlineData("", false)] // ID rỗng
        [InlineData(null, false)] // ID null

        public async Task GetByIdAsync_WithVariousInputs_ReturnsExpected(string? idStr, bool expectedResult)
        {
            try
            {
                // Chuyển đổi ID từ string sang GUID (nếu không null/rỗng)
                Guid? id = string.IsNullOrEmpty(idStr) ? null : Guid.Parse(idStr);

                // Gọi phương thức cần test
                var result = await _repo.GetById(id);

                // Assert: So sánh kết quả mong đợi
                Assert.Equal(expectedResult, result != null);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi xảy ra: {ex.Message}");

                // Nếu ID sai định dạng hoặc null, kiểm tra xem có ném lỗi không
                Assert.False(expectedResult);
            }
        }
    }
}
