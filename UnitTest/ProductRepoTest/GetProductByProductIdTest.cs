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

namespace UnitTest.ProductRepoTest
{
    public class GetProductByProductIdTest
    {
        private readonly IProductRepository _repo;
        private readonly SufyStylesShopContext _context;

        public GetProductByProductIdTest()
        {
          
            _context = new SufyStylesShopContext();
            _repo = new ProductRepository(_context);

        }

       
        [Theory]
        [InlineData("B9F3D0D4-6F68-400F-BAD2-9B83EB673ACA", true)] // Sản phẩm tồn tại
        [InlineData("FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF", false)] // Sản phẩm không tồn tại

        public async Task GetProductByProductId_WithVariousInputs_ReturnsExpected(string productIdStr, bool expectedResult)
        {
            try
            {
                Guid productId = Guid.Parse(productIdStr);
                var result = await _repo.GetProductByProductId(productId);
                bool actualResult = result != null;

                Assert.Equal(expectedResult, actualResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi xảy ra: {ex.Message}");
                Assert.False(expectedResult);
            }
        }
    }
}
