using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.IRepository;
using Repositories.Repository;
using Repository.IRepository;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.AccountManageRepo
{
    public class GetUsersByRoleTest
    {
        private readonly IAccountManageRepository _repo;
        private readonly SufyStylesShopContext _context;

        public GetUsersByRoleTest()
        {
           
            _context = new SufyStylesShopContext();
            _repo = new AccountManageRepository(_context);

        }

        [Theory]
        [InlineData("Admin", 1)] 
        [InlineData("Moderator", 0)] 

        public async Task GetUsersByRole_WithVariousRoles_ReturnsExpected(string role, int expectedCount)
        {
            try
            {
                // Gọi phương thức cần test
                var result = await _repo.GetUsersByRole(role);

                // Kiểm tra số lượng kết quả trả về
                Assert.Equal(expectedCount, result.Count);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi xảy ra: {ex.Message}");
                Assert.True(false, $"Test thất bại: {ex.Message}");
            }
        }
    }
}
