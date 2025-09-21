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
    public class FindUserByPhoneTest
    {
        private readonly IUserRepository _repo;
        private readonly SufyStylesShopContext _context;

        public FindUserByPhoneTest()
        {
            _context = new SufyStylesShopContext();
            _repo = new UserRepository(_context);
        }

        [Theory]
        [InlineData("0945732336", true)] // Số điện thoại hợp lệ
        [InlineData("0111111111", false)] // Số điện thoại rỗng
      
        public async Task FindUserByPhone_WithVariousInputs_ReturnsExpected(string phoneNumber, bool expectedResult)
        {
            try
            {
                var result = await _repo.GetEmailByPhone(phoneNumber);

                Assert.Equal(expectedResult, result != null);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi xảy ra: {ex.Message}");
                Assert.False(expectedResult);
            }
        }
    }
}
