using BussinessObject.Model;
using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.IRepository;
using Repositories.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.UserVoucherTest
{
    public class CheckVoucherUsedTest
    {
        private readonly IUserVoucherRepository _repo;
        private readonly SufyStylesShopContext _context;

        public CheckVoucherUsedTest()
        {
          
            _context = new SufyStylesShopContext();
            _repo = new UserVoucherRepository(_context);        
        }

     

        [Theory]
        [InlineData("C33912D3-4525-43F1-B893-07580F2C4226", "B9F3D0D4-6F68-400F-BAD2-9B83EB673ACA", true)]  // User đã sử dụng voucher
        [InlineData("C33912D3-4525-43F1-B893-07580F2C4226", "DDDDDDDD-DDDD-DDDD-DDDD-DDDDDDDDDDDD", false)] // Voucher không tồn tại
        [InlineData("FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF", "B9F3D0D4-6F68-400F-BAD2-9B83EB673ACA", false)] // User không tồn tại
        [InlineData("FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF", "DDDDDDDD-DDDD-DDDD-DDDD-DDDDDDDDDDDD", false)]
        public async Task CheckVoucherUsed_WithVariousInputs_ReturnsExpected(string userIdStr, string voucherIdStr, bool expectedResult)
        {
            try
            {
                // Chuyển đổi GUID từ string
                Guid userId = Guid.Parse(userIdStr);
                Guid voucherId = Guid.Parse(voucherIdStr);

                // Gọi phương thức cần test
                var result = await _repo.CheckVoucherUsed(userId, voucherId);

                // So sánh kết quả mong đợi
                Assert.Equal(expectedResult, result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi xảy ra: {ex.Message}");
                Assert.False(expectedResult);
            }
        }
    }
}
