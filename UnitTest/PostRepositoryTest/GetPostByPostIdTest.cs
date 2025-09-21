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
    public class GetPostByPostIdTest
    {
        private readonly IPostRepository _repo;
        private readonly SufyStylesShopContext _context;

        public GetPostByPostIdTest()
        {
            _context = new SufyStylesShopContext();
            _repo = new PostRepository(_context);
        }

        [Theory]
        [InlineData("B9F3D0D4-6F68-400F-BAD2-9B83EB673ACA", true)] // Bài viết tồn tại
        [InlineData("FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF", false)] // Bài viết không tồn tại
      
        public async Task GetById_WithVariousInputs_ReturnsExpected(string postIdStr, bool expectedResult)
        {
            try
            {
                Guid? postId = string.IsNullOrEmpty(postIdStr) ? null : Guid.Parse(postIdStr);

                var result = await _repo.GetById(postId);

                bool actualResult = result != null;

                Assert.Equal(expectedResult, actualResult);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Lỗi xảy ra: {ex.Message}");
                Assert.False(expectedResult); 
            }
        }
    }
}
