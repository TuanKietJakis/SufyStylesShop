using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class CartRepository : ICartRepository
    {
        private readonly SufyStylesShopContext _context;

        public CartRepository(SufyStylesShopContext context)
        {
            _context = context;
        }

        public async Task<List<CartItem>> GetListCartItemsByUserId(Guid userId)
        {
            return await _context.CartItems
                .Where(ci => ci.UserId == userId && !ci.IsDeleted)  
                .Include(ci => ci.Product) 
                    .Where(p => !p.IsDeleted) 
               
                .Include(ci => ci.Product.ProductVendor) 
                .Include(ci => ci.Product.ProductVariants.Where(v => v.Quantity > 0))  
                .ToListAsync();
        }
        public async Task Add(CartItem cartItem)
        {
            await _context.CartItems.AddAsync(cartItem);
            await _context.SaveChangesAsync();
        }

        public async Task Update(CartItem cartItem)
        {
             _context.CartItems.Update(cartItem);
            await _context.SaveChangesAsync();
        }

        public async Task<CartItem?> GetCartItemById(Guid cartItemId)
        {
            return await _context.CartItems
                .Include(ci => ci.Product) // Bao gồm Product nếu cần
                .FirstOrDefaultAsync(ci => ci.CartItemId == cartItemId);
        }
        public async Task<CartItem?> GetCartItemByUserIdAndProduct(Guid userId, Guid productId, Guid? variantId)
        {
            return await _context.CartItems
                .Where(ci => ci.UserId == userId && ci.ProductId == productId && ci.VariantId == variantId)
                .Include(ci => ci.Product)
                    .Where(p => !p.IsDeleted)
               
                .Include(ci => ci.Product.ProductVendor)
                .Include(ci => ci.Product.ProductVariants.Where(v => v.Quantity > 0))
                .FirstOrDefaultAsync();
        }

    }
}
