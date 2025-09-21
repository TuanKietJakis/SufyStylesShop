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
    public class GetAllPostTest
    {
        private readonly IPostRepository _repo;
        private readonly SufyStylesShopContext _context;

        public GetAllPostTest()
        {
            _context = new SufyStylesShopContext();
            _repo = new PostRepository(_context);
        }

        [Fact]
        public void GetAll_ReturnsAllPosts()
        {
            // Act: Gọi phương thức GetAll()
            var result = _repo.GetAll();

            // Assert: Kiểm tra xem dữ liệu có được trả về không
            Assert.NotNull(result); // Đảm bảo kết quả không null
            Assert.True(result.Any()); // Đảm bảo có ít nhất 1 bài post trong DB
        }
    }
}
