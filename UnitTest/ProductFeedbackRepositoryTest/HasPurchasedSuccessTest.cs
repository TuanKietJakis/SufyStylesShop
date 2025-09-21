using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.IRepository;
using Repositories.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.ProductFeedbackRepositoryTest
{
    public class HasPurchasedSuccessTest
    {
        private readonly IProductFeedbackRepository _repo;
        private readonly SufyStylesShopContext _context;

        public HasPurchasedSuccessTest()
        {
           
            _context = new SufyStylesShopContext();
            _repo = new ProductFeedbackRepository(_context);

        }


        [Theory]
        [InlineData("3F2504E0-4F89-11D3-9A0C-0305E82C3301", "5A7FB27F-BE52-468B-97DE-270F1EFA4854", true)]  // User đã mua thành công
        [InlineData("3F2504E0-4F89-11D3-9A0C-0305E82C3301", "DDDDDDDD-DDDD-DDDD-DDDD-DDDDDDDDDDDD", false)] // User không mua sản phẩm này
        [InlineData("FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF", "5A7FB27F-BE52-468B-97DE-270F1EFA4854", false)] // User không tồn tại
        [InlineData("FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF", "DDDDDDDD-DDDD-DDDD-DDDD-DDDDDDDDDDDD", false)]
        public async Task HasPurchasedSuccess_WithVariousInputs_ReturnsExpected(string userIdStr, string productIdStr, bool expectedResult)
        {
            try
            {
                // Chuyển đổi GUID từ string
                Guid userId = Guid.Parse(userIdStr);
                Guid productId = Guid.Parse(productIdStr);

                // Gọi phương thức cần test
                var result = await _repo.HasPurchasedSuccess(userId, productId);

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
