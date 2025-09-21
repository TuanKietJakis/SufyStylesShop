using APIService.Extension;
using APIService.Service;
using BussinessObject.DTO.Order;
using BussinessObject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace APIService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class OrdersController : ControllerBase
    {
        private readonly OrderService _orderService;

        public OrdersController(OrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] OrderCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();
                return BadRequest(new { errors });
            }
            try
            {
                var curentUserId = JwtHelper.GetUserIdFromClaims(User);
                request.UserId = curentUserId;
                var orderId = await _orderService.CreateOrder(request);
                if (request.PaymentMethodId.ToString().ToUpper() == "F1E2D3C4-B5A6-7890-1234-56789ABCDEF1")
                {
                    return Ok(new
                    {
                        message = "Order created, proceed to payment",
                        OrderId = orderId
                    });
                }

                return Ok(new { message = "Tạo order thành công" });
            }

            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
        [HttpGet("GetDetail/{orderId}")]
        public async Task<IActionResult> GetOrderByOrderId(Guid orderId)
        {
            try
            {
                // Lấy order theo orderId
                var order = await _orderService.GetOrderDetail(orderId);

                if (order == null)
                {
                    return NotFound(new { message = "Order not found" });
                }

                return Ok(order);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpGet("users/{userId}")]
        public async Task<IActionResult> GetOrderByUserId(Guid userId)
        {
            try
            {
                // Lấy order theo orderId
                var orders = await _orderService.GetOrderByUserId(userId);

                return Ok(orders);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpGet("Payment/GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var payments = await _orderService.GetAllPayment();
                return Ok(payments);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
