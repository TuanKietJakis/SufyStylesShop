using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepository
{
    public interface ICartRepository
    {
        Task<List<CartItem>> GetListCartItemsByUserId(Guid userId);
        Task<CartItem?> GetCartItemById(Guid cartItemId);
        Task<CartItem?> GetCartItemByUserIdAndProduct(Guid userId, Guid productId, Guid? variantId);
        Task Add(CartItem cartItem);
        Task Update(CartItem cartItem);
      
    }
}
