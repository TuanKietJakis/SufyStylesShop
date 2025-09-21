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
    public class GetFollowTest
    {
        private readonly IUserRepository _repo;
        private readonly SufyStylesShopContext _context;

        public GetFollowTest()
        {
            _context = new SufyStylesShopContext();
            _repo = new UserRepository(_context);
        }

        [Theory]
        [InlineData("B9F3D0D4-6F68-400F-BAD2-9B83EB673ACA", "F9A1D3E5-3C7B-482A-9229-4F3E1A8741B1", true)] // Follow tồn tại
        [InlineData("FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF", "BBBBBBBB-BBBB-BBBB-BBBB-BBBBBBBBBBBB", false)] // Follow không tồn tại
        [InlineData("FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF", "F9A1D3E5-3C7B-482A-9229-4F3E1A8741B1", false)]
        [InlineData("B9F3D0D4-6F68-400F-BAD2-9B83EB673ACA", "BBBBBBBB-BBBB-BBBB-BBBB-BBBBBBBBBBBB", false)]
        public async Task GetFollow_WithVariousInputs_ReturnsExpected(string followerIdStr, string followingIdStr, bool expectedResult)
        {
            try
            {
                Guid followerId = Guid.Parse(followerIdStr);
                Guid followingId = Guid.Parse(followingIdStr);

                var result = await _repo.GetFollow(followerId, followingId);

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
