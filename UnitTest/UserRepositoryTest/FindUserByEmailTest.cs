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
    public class FindUserByEmailTest
    {
        private readonly IUserRepository _repo;
        private readonly SufyStylesShopContext _context;

        public FindUserByEmailTest()
        {
            _context = new SufyStylesShopContext();
            _repo = new UserRepository(_context);
        }

        [Theory]
        [InlineData("duongsitien321@gmail.com", true)] // Email hợp lệ
        [InlineData("tien12345@gmail.com", false)] // Email rỗng
     
    
        public async Task FindUserByEmail_WithVariousInputs_ReturnsExpected(string email, bool expectedResult)
        {
            try
            {
                var result = await _repo.GetUserByEmail(email);
                Assert.Equal(expectedResult, result != null);
            }
            catch (Exception ex)
            {
                Assert.False(expectedResult, $"Lỗi xảy ra: {ex.Message}");     
            }
        }
    }
}
