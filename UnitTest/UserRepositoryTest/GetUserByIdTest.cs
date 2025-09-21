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

namespace UnitTest.UserRepositoryTest
{
    public class GetUserByIdTest
    {
        private readonly IUserRepository _repo;
        private readonly SufyStylesShopContext _context;

        public GetUserByIdTest()
        {
            _context = new SufyStylesShopContext();
            _repo = new UserRepository(_context);
        }

        [Theory]
        [InlineData("B9F3D0D4-6F68-400F-BAD2-9B83EB673ACA", true)] // User tồn tại và chưa bị xóa
        [InlineData("FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF", false)] // User không tồn tại
       

        public async Task GetUserById_WithVariousInputs_ReturnsExpected(string userIdStr, bool expectedResult)
        {
            try
            {
                Guid userId = Guid.Parse(userIdStr);

                var result = await _repo.GetUserById(userId);

                Assert.Equal(expectedResult, result != null);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi xảy ra: {ex.Message}");
                Assert.True(false, $"Test thất bại: {ex.Message}");
            }
        }
    }
}
