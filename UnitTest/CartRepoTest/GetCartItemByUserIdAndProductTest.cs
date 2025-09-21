using BussinessObject.Models;
using Repositories.IRepository;
using Repositories.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.CartRepoTest
{
    public class GetCartItemByUserIdAndProductTest
    {
        private readonly ICartRepository _repo;
        private readonly SufyStylesShopContext _context;

        public GetCartItemByUserIdAndProductTest()
        {
            _context = new SufyStylesShopContext();
            _repo = new CartRepository(_context);
        }

        [Theory]
      
        // 1
        [InlineData("3F2504E0-4F89-11D3-9A0C-0305E82C3301", "5A7FB27F-BE52-468B-97DE-270F1EFA4854", "577C5216-9EF6-4839-8B8C-DBF05147B930", true)]

        // 2
        [InlineData("3F2504E0-4F89-11D3-9A0C-0305E82C3301", "5A7FB27F-BE52-468B-97DE-270F1EFA4854", "BBBBBBBB-BBBB-BBBB-BBBB-BBBBBBBBBBBB", false)] // Hoặc true tùy logic
                                                                                                                                          //3
        [InlineData("3F2504E0-4F89-11D3-9A0C-0305E82C3301", "DDDDDDDD-DDDD-DDDD-DDDD-DDDDDDDDDDDD", "577C5216-9EF6-4839-8B8C-DBF05147B930", false)]

        //4
        [InlineData("FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF", "5A7FB27F-BE52-468B-97DE-270F1EFA4854", "577C5216-9EF6-4839-8B8C-DBF05147B930", false)]

        //5
        [InlineData("3F2504E0-4F89-11D3-9A0C-0305E82C3301", "DDDDDDDD-DDDD-DDDD-DDDD-DDDDDDDDDDDD", "577C5216-9EF6-4839-8B8C-DBF05147B930", false)]

        //6
        [InlineData("3F2504E0-4F89-11D3-9A0C-0305E82C3301", "DDDDDDDD-DDDD-DDDD-DDDD-DDDDDDDDDDDD", "BBBBBBBB-BBBB-BBBB-BBBB-BBBBBBBBBBBB", false)]

        //7
        [InlineData("FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF", "5A7FB27F-BE52-468B-97DE-270F1EFA4854", "BBBBBBBB-BBBB-BBBB-BBBB-BBBBBBBBBBBB", false)]

        //8
        [InlineData("FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF", "DDDDDDDD-DDDD-DDDD-DDDD-DDDDDDDDDDDD", "BBBBBBBB-BBBB-BBBB-BBBB-BBBBBBBBBBBB", false)]

        public async Task GetCartItem_WithAllCombinations_ReturnsExpected(
    string userId,
    string productId,
    string variantId,
    bool expectedResult)
        {
            // Act
            var result = await _repo.GetCartItemByUserIdAndProduct(
                Guid.Parse(userId),
                Guid.Parse(productId),
               Guid.Parse(variantId)
            );

            // Assert
            Assert.Equal(expectedResult, result != null);
        }
    }
}
