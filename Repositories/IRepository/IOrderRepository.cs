using BussinessObject.DTO;
using BussinessObject.DTO.Order;
using BussinessObject.Models;

namespace Repositories.IRepository
{
    public interface IOrderRepository
    {
   
        Task<Order> CreateOrder(Order order);
        Task<bool> CheckPaymentMethod(Guid paymentMethodId);
        Task<ProductVariant?> GetProductVariant(Guid variantId);
        Task<List<Order>> GetOrderByUserId(Guid userId);
        Task<IEnumerable<PaymentMethod>> GetAllPayment();

        // CRUD Methods
        IQueryable<Order> GetAll();
        Task<Order?> GetById(params Guid?[]? id);
        void Update(Order entity);
        Task SaveChanges();
    }
}