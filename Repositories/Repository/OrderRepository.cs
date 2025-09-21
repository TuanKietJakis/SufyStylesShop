using BussinessObject.DTO.Order;
using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.IRepository;
using System.Linq.Expressions;

namespace Repositories.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly SufyStylesShopContext _context;
        private readonly DbSet<Order> _dbSet;

        public OrderRepository(SufyStylesShopContext context)
        {
            _context = context;
            _dbSet = context.Set<Order>();
        }

        public IQueryable<Order> GetAll() => _dbSet.AsQueryable();

        public async Task<Order?> GetById(params Guid?[]? id)
        {
            if (id == null || id.Length == 0)
                throw new ArgumentException("At least one ID is required.");

            return await _dbSet
                .Include(o => o.PaymentMethod)
                .Include(o => o.OrderDetails)
                    .ThenInclude(od => od.ProductVariant)
                        .ThenInclude(pv => pv.Product)
                .FirstOrDefaultAsync(o => o.OrderId == id[0]);
        }

        public void Update(Order entity) => _dbSet.Update(entity);
       

        public async Task SaveChanges() => await _context.SaveChangesAsync();

       
        public async Task<Order> CreateOrder(Order order)
        {
            await _dbSet.AddAsync(order);
            await SaveChanges();
            return order;
        }

        public async Task<bool> CheckPaymentMethod(Guid paymentMethodId) =>
            await _context.PaymentMethods.AnyAsync(pm => pm.PaymentMethodId == paymentMethodId);

        public async Task<ProductVariant?> GetProductVariant(Guid variantId) =>
            await _context.ProductVariants
                .Include(pv => pv.Product)
                .FirstOrDefaultAsync(pv => pv.VariantId == variantId);

        public async Task<List<Order>> GetOrderByUserId(Guid userId) =>
            await _dbSet
                .Include(o => o.PaymentMethod)
                .Include(o => o.OrderDetails)
                    .ThenInclude(od => od.ProductVariant)
                        .ThenInclude(pv => pv.Product)
                .Where(o => o.UserId == userId)
                .ToListAsync();

        public async Task<IEnumerable<PaymentMethod>> GetAllPayment() =>
            await _context.PaymentMethods
                .Where(p => !p.IsDeleted)
                .ToListAsync();
    }
}
