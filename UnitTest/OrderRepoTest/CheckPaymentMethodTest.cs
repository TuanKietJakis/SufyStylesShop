using BussinessObject.Models;
using Repositories.IRepository;
using Repositories.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.OrderRepoTest
{
    public class CheckPaymentMethodTest
    {
        private readonly IOrderRepository _repo;
        private readonly SufyStylesShopContext _context;

        public CheckPaymentMethodTest()
        {
            _context = new SufyStylesShopContext();
            _repo = new OrderRepository(_context);
        }

        [Theory]
        [InlineData("D1E2F3A4-B5C6-7890-1234-56789ABCDEF0", true)] // PaymentMethodId hợp lệ
        [InlineData("FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF", false)] // PaymentMethodId không tồn tại

        public async Task CheckPaymentMethod_WithVariousInputs_ReturnsExpected(string paymentMethodIdStr, bool expectedResult)
        {
            try
            {
                Guid paymentMethodId = Guid.Parse(paymentMethodIdStr);

                var result = await _repo.CheckPaymentMethod(paymentMethodId);

                // Kiểm tra kết quả
                Assert.Equal(expectedResult, result);
            }
            catch (Exception ex)
            {
                Assert.False(expectedResult, $"Lỗi xảy ra: {ex.Message}");
            }
        }
    }
}
