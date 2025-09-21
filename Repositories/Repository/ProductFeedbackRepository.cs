using BussinessObject.Model;
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
    public class ProductFeedbackRepository : IProductFeedbackRepository
    {
        private readonly SufyStylesShopContext _context;

        public ProductFeedbackRepository(SufyStylesShopContext context)
        {
            _context = context;
        }

        public async Task AddFeedback(ProductFeedback feedback)
        {
            await _context.Set<ProductFeedback>().AddAsync(feedback);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> ProductExist(Guid productId)
        {
            return await _context.Set<Product>().AnyAsync(p => p.ProductId == productId);
        }

        public async Task<bool> UserExist(Guid userId)
        {
            return await _context.Set<User>().AnyAsync(u => u.UserId == userId);
        }
        public async Task UpdateFeedback(ProductFeedback feedback)
        {
            _context.Set<ProductFeedback>().Update(feedback);
            await _context.SaveChangesAsync();
        }

        public async Task<ProductFeedback> GetFeedbackById(Guid feedbackId)
        {
            return await _context.Set<ProductFeedback>()
                .FirstOrDefaultAsync(f => f.ProductFeedbackId == feedbackId);
        }

        public async Task<List<ProductFeedback>> GetAllFeedbacks()
        {
            return await _context.Set<ProductFeedback>()
                .Include(f => f.Product) // Load Product data
                .Include(f => f.User)    // Load User data
                .Where(f => !f.IsDeleted)
                .OrderByDescending(f => f.CreatedDate)
                .ToListAsync();
        }

        public async Task<bool> HasPurchasedSuccess(Guid userId, Guid productId)
        {
            return await _context.Orders
                .Where(o => o.UserId == userId && o.OrderStatus == 2) 
                .AnyAsync(o => o.OrderDetails.Any(od => od.ProductId == productId)); 
        }
        public async Task<ProductFeedback?> GetFeedbackByProductAndUser(Guid productId, Guid userId)
        {
            return await _context.ProductFeedbacks
                .Include(f => f.Product) 
                .Include(f => f.User)    
                .Where(f => f.ProductId == productId && f.UserId == userId && !f.IsDeleted)
                .FirstOrDefaultAsync();
        }
        public async Task<ProductFeedback?> GetFeedbackByUser(Guid userId)
        {
            return await _context.ProductFeedbacks   
                .Include(f => f.Product)
                .Include(f => f.User)    
                .Where(f => f.UserId == userId && !f.IsDeleted)
                .FirstOrDefaultAsync();
        }

    }
}
