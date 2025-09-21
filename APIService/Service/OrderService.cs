using BussinessObject.DTO.Order;
using BussinessObject.DTO.Post;
using BussinessObject.Model;
using BussinessObject.Models;
using ISUZU_NEXT.Server.Core.Extentions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositories.IRepository;
using Repository.IRepository;

namespace APIService.Service
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IUserVoucherRepository _userVoucherRepository;
        private readonly IUserRepository _userRepository;

        public OrderService(IOrderRepository orderRepository, IUserVoucherRepository userVoucherRepository, IUserRepository userRepository)
        {
            _orderRepository = orderRepository;
            _userVoucherRepository = userVoucherRepository;
            _userRepository = userRepository;
        }
      
    
        public async Task UpdateOrder(Guid staffId, Guid orderId, UpdateOrderRequest request)
        {
            var validStatuses = new Dictionary<string, int>
    {
        { "Confirmed", 1 },
        { "Rejected", -1 },
      
        { "DeliverySuccess", 2 },
        { "DeliveryFailed", -2 }
    };

            if (!validStatuses.ContainsKey(request.Status))
            {
                throw new ArgumentException("Error format status. Only: Confirmed, Rejected,  DeliverySuccess, DeliveryFailed.");
            }

            var staff = await _userRepository.GetUserById(staffId);
            if (staff == null)
            {
                throw new Exception("User not found");
            }

            var order = await _orderRepository.GetById(orderId);
            if (order == null)
            {
                throw new ArgumentException("Order not found");
            }

            order.ComfirmUserId = staffId;
            order.Staff = staff;
            order.OrderStatus = validStatuses[request.Status];

            switch (request.Status)
            {
                case "Confirmed":
                    order.ComfirmDate = DateTime.Now;
                    break;

                case "Rejected":
                    if (string.IsNullOrWhiteSpace(request.Reason))
                    {
                        throw new ArgumentException("Reason is required");
                    }
                    order.ReasonCancel = request.Reason;
                    order.CancelDate = DateTime.Now;
                    break;

                case "DeliverySuccess":
                    
                    break;

                case "DeliveryFailed":
                    if (string.IsNullOrWhiteSpace(request.Reason))
                    {
                        throw new ArgumentException("Reason is required");
                    }
                    order.ReasonCancel = request.Reason;
                    
                    break;
            }

            _orderRepository.Update(order);
            await _orderRepository.SaveChanges();
        }
        public async Task<Guid> CreateOrder(OrderCreateRequest request)
        {
            var voucherPrice = 0;
            var haveVoucher = false;
            if (request.VoucherId.HasValue)
            {
                var userVoucher = await _userVoucherRepository.GetById(request.VoucherId.Value);
               
                if (userVoucher == null || userVoucher.CurrentUsage >= userVoucher.MaxUsage)
                {
                    throw new ArgumentException("Voucher not found or cannot use.");
                }

                var voucherCheck = await _userVoucherRepository.CheckVoucherUsed(request.UserId, request.VoucherId.Value);
                if (voucherCheck)
                {
                    throw new ArgumentException("Voucher used before.");
                }
                haveVoucher = true;
                voucherPrice = userVoucher.DiscountValue;
            }

            var existPaymentMethod = await _orderRepository.CheckPaymentMethod(request.PaymentMethodId);
            if (!existPaymentMethod)
            {
                throw new ArgumentException("PaymentMethod not found");
            }


            // Tạo đơn hàng và chi tiết đơn hàng
            var order = new Order
            {
                UserId = request.UserId,
                PaymentMethodId = request.PaymentMethodId,
                Address = request.Address,
                Fullname = request.Fullname,
                PaymentStatus = request.PaymentStatus,
                OrderStatus = request.OrderStatus,
                OrderShippingFee = request.OrderShippingFee,
                OrderTotalPrice = 0,
                SubTotal = 0,
                Phone = request.Phone,
                CreatedDate = DateTime.Now
            };

            foreach (var detail in request.OrderDetails)
            {
                var productVariant = await _orderRepository.GetProductVariant(detail.VariantId);

                if (productVariant == null)
                {
                    throw new ArgumentException($"Product not found");
                }
                if (productVariant.Quantity < detail.Quantity)
                {
                    throw new ArgumentException($"Product out of stock");
                }

                productVariant.Quantity -= detail.Quantity; // Giảm số lượng sản phẩm

                order.SubTotal += productVariant.Price * detail.Quantity;

                order.OrderDetails.Add(new OrderedDetail
                {
                    ProductId = productVariant.ProductId,
                    VariantId = detail.VariantId,
                    ProductName = productVariant.Product!.ProductName,
                    Quantity = detail.Quantity,
                    ProductPrice = productVariant.Price
                });
            }

            if (haveVoucher)
            {
                if(order.SubTotal < voucherPrice)
                {
                    throw new ArgumentException($"Cannot use voucher");
                }
            }

            order.OrderTotalPrice = order.OrderShippingFee + order.SubTotal - voucherPrice;

            // Lưu order và giảm CurrentUsage của UserVoucher nếu có
            await _orderRepository.CreateOrder(order);

            if (request.VoucherId.HasValue)
            {
                await _userVoucherRepository.IncreaseCurrentUsage(request.UserId, request.VoucherId.Value);
            }

            return order.OrderId;

        }

        public async Task<List<OrderDTO>> GetAllOrders()
        {
            var orders = await _orderRepository.GetAll()
                .Include(o => o.OrderDetails)
                    .ThenInclude(od => od.ProductVariant)
                        .ThenInclude(pv => pv.Product)
                .ToListAsync();
            var dtos = new List<OrderDTO>();
            orders.ForEach(order =>
            {
                var dto = new OrderDTO();
                dto.CopyProperties(order);
                dtos.Add(dto);
            });
          
            return dtos;
        }
        public async Task<Order?> GetOrderById(Guid orderId)
        {
            var order = await _orderRepository.GetById(orderId);
            return order;
        }
        public async Task<OrderDTO?> GetOrderDetail(Guid orderId)
        {
            var order = await _orderRepository.GetById(orderId);
            if (order == null) return null;
            var dto =new OrderDTO();
            dto.CopyProperties(order);
            return dto;
        }
        public async Task<List<OrderDTO>> GetOrderByUserId(Guid orderId)
        {
            var orders = await _orderRepository.GetOrderByUserId(orderId);
            var dtos = new List<OrderDTO>();
            orders.ForEach(order =>
            {
                var dto = new OrderDTO();
                dto.CopyProperties(order);
                dtos.Add(dto);
            });
         
            return dtos;
        }

        public async Task UpdateOrderAddress(UpdateAddressOrder request)
        {
            var order = await _orderRepository.GetById(request.OrderId);
            if (order == null)
            {
                throw new ArgumentException("Not found.");
            }
         
            order.CopyProperties(request);

             _orderRepository.Update(order);
            await _orderRepository.SaveChanges();
        } 
        public async Task UpdatePayment(UpdatePaymentRequest request)
        {
            var order = await _orderRepository.GetById(request.OrderId);
            if (order == null)
            {
                throw new ArgumentException("Not found.");
            }
           
            order.CopyProperties(request);

             _orderRepository.Update(order);
            await _orderRepository.SaveChanges();
        }
        public async Task<IEnumerable<PaymentMethod>> GetAllPayment()
        {
            return await _orderRepository.GetAllPayment();
        }
    }
}
