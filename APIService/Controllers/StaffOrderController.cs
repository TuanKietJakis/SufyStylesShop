using APIService.Extension;
using APIService.Service;
using BussinessObject.DTO;
using BussinessObject.DTO.Order;
using BussinessObject.DTO.UserVoucher;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APIService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Staff,Admin")]
    public class StaffOrderController : ControllerBase
    {
        private readonly OrderService _orderService;
        private readonly UserVoucherService _userVoucherService;
        public StaffOrderController (OrderService orderService, UserVoucherService userVoucherService)
        {
            _orderService = orderService;
            _userVoucherService = userVoucherService;
        }

        [HttpGet("Order/GetAll")]
        public async Task<IActionResult> GetOrders()
        {
            try
            {
                var orders = await _orderService.GetAllOrders();

                return Ok(orders);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost("Order/Create")]
        public async Task<IActionResult> CreateOrder([FromBody] OrderCreateRequest request)
        {
            try
            {
                var curentUserId = JwtHelper.GetUserIdFromClaims(User);
                request.UserId = curentUserId;
                await _orderService.CreateOrder(request);
                return Ok(new { message = "Tạo order thành công" });
            }

            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPut("Order/Update/{orderId}")]
        public async Task<IActionResult> UpdateOrder(Guid orderId, [FromBody] UpdateOrderRequest request)
        {
            try
            {
                var curentUserId = JwtHelper.GetUserIdFromClaims(User);
                await _orderService.UpdateOrder(curentUserId, orderId, request);

                return Ok(new { message = "Update successfully" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpGet("Order/GetDetail/{orderId}")]
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

        [HttpPut("Order/UpdateAddress")]
        public async Task<IActionResult> UpdateOrderAddress([FromBody] UpdateAddressOrder request)
        {
            if (request == null || request.OrderId == Guid.Empty)
            {
                return BadRequest("Invalid order information.");
            }
          

            await _orderService.UpdateOrderAddress(request);
            return Ok("Order address updated successfully.");
        }

        [HttpGet("ShowVoucher")]
        public async Task<IActionResult> GetVouchers([FromQuery] UserVoucherPaginationParams.AdminFilter paginationParams)
        {
            try
            {
                var paginatedVouchers = await _userVoucherService.GetAllVouchers(paginationParams);
                return Ok(paginatedVouchers);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost("CreateVoucher")]
        public async Task<IActionResult> CreateVoucher([FromBody] UserVoucherCreateDto dto)
        {
            try
            {
                dto.UserId = JwtHelper.GetUserIdFromClaims(User);
                var result = await _userVoucherService.CreateVoucher(dto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPut("UpdateVoucher/{voucherId}")]
        public async Task<IActionResult> UpdateVoucher(Guid voucherId, [FromBody] UserVoucherUpdateDto dto)
        {
            try
            {
                dto.VoucherId = voucherId;
                dto.UserId = JwtHelper.GetUserIdFromClaims(User);
                await _userVoucherService.UpdateVoucher(dto);
                return Ok(new { message = "Update Voucher succcess" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPut("VoucherActive/{voucherId}")]
        public async Task<IActionResult> ActiveVoucher(Guid voucherId)
        {
            try
            {
                await _userVoucherService.UpdateStatus(voucherId, true);
                return Ok(new { message = "Update Voucher Status succcess" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPut("VoucherInActive/{voucherId}")]
        public async Task<IActionResult> InActiveVoucher(Guid voucherId)
        {
            try
            {
                await _userVoucherService.UpdateStatus(voucherId, false);
                return Ok(new { message = "Update Voucher Status succcess" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
