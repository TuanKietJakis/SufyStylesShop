using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.IRepository;
using Repositories.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.OrderRepoTest
{
    public class GetOrderByUserIdTest
    {
        private readonly IOrderRepository _repo;
        private readonly SufyStylesShopContext _context;

        public GetOrderByUserIdTest()
        {
           
            _context = new SufyStylesShopContext();
            _repo = new OrderRepository(_context);

        }

     
        [Theory]
        [InlineData("C33912D3-4525-43F1-B893-07580F2C4226", true)] // Có đơn hàng
        [InlineData("FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF", false)] // Không có đơn hàng

        public async Task GetOrderByUserId_WithVariousInputs_ReturnsExpected(string userIdStr, bool expectedResult)
        {
            try
            {
                Guid userId = Guid.Parse(userIdStr);

                var result = await _repo.GetOrderByUserId(userId);

                bool actualResult = result.Count > 0;

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
