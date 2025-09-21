using APIService.Extension;
using APIService.Service;
using BussinessObject.DTO.Order;
using BussinessObject.Services.Payment;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.X9;

namespace APIService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly OrderService _orderService;
        //Get Config Info
        private readonly string vnp_Returnurl = "http://localhost:5173/vnpay-return"; //URL nhan ket qua tra ve 
        private readonly string vnp_Url = "https://sandbox.vnpayment.vn/paymentv2/vpcpay.html"; //URL thanh toan cua VNPAY 
        private readonly string vnp_TmnCode = "9UH5GQ7A"; //Ma định danh merchant kết nối (Terminal Id)
        private readonly string vnp_HashSecret = "1TYCY9QC0APTJSY86DXZLVIUZAL6CF49"; //Secret Key
        private readonly string vnp_BankCode = "NCB";
        private readonly string vnp_Locale = "vn";


        public PaymentController(OrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePayment([FromBody] CreatePayment request)
        {
            try
            {
                var order = await _orderService.GetOrderById(request.OrderId);
                if (order == null)
                {
                    return BadRequest(new { message = "Order not found" });
                }


                string ipAddress = Request.Headers["X-Forwarded-For"].FirstOrDefault();

                if (string.IsNullOrEmpty(ipAddress) || (ipAddress.ToLower() == "unknown") || ipAddress.Length > 45)
                    ipAddress = Request.Headers["REMOTE_ADDR"];

                if(ipAddress == null)
                {
                    ipAddress = "14.191.95.88";
                }
                

                //Get payment input
             
                OrderInfo orderInfo = new OrderInfo();
                orderInfo.OrderId = DateTime.Now.Ticks; // Giả lập mã giao dịch hệ thống merchant gửi sang VNPAY
                orderInfo.Amount = order.OrderTotalPrice.HasValue ? (long)(order.OrderTotalPrice * 100) : 0; // Giả lập số tiền thanh toán hệ thống merchant gửi sang VNPAY 100,000 VND
                orderInfo.Status = "0"; //0: Trạng thái thanh toán "chờ thanh toán" hoặc "Pending" khởi tạo giao dịch chưa có IPN
                orderInfo.CreatedDate = DateTime.Now;

                //Build URL for VNPAY
                VnPayLibrary vnpay = new VnPayLibrary();

                vnpay.AddRequestData("vnp_Version", VnPayLibrary.VERSION);
                vnpay.AddRequestData("vnp_Command", "pay");
                vnpay.AddRequestData("vnp_TmnCode", vnp_TmnCode);
                vnpay.AddRequestData("vnp_Amount", orderInfo.Amount.ToString()); //Số tiền thanh toán. Số tiền không mang các ký tự phân tách thập phân, phần nghìn, ký tự tiền tệ. Để gửi số tiền thanh toán là 100,000 VND (một trăm nghìn VNĐ) thì merchant cần nhân thêm 100 lần (khử phần thập phân), sau đó gửi sang VNPAY là: 10000000

                vnpay.AddRequestData("vnp_BankCode", vnp_BankCode);

                vnpay.AddRequestData("vnp_CreateDate", orderInfo.CreatedDate.ToString("yyyyMMddHHmmss"));
                vnpay.AddRequestData("vnp_CurrCode", "VND");
                vnpay.AddRequestData("vnp_IpAddr", ipAddress);

                vnpay.AddRequestData("vnp_Locale", vnp_Locale);

                vnpay.AddRequestData("vnp_OrderInfo", "Thanh toan don hang:" + order.OrderId);
                vnpay.AddRequestData("vnp_OrderType", "other"); //default value: other

                vnpay.AddRequestData("vnp_ReturnUrl", vnp_Returnurl);
                vnpay.AddRequestData("vnp_TxnRef", orderInfo.OrderId.ToString()); // Mã tham chiếu của giao dịch tại hệ thống của merchant. Mã này là duy nhất dùng để phân biệt các đơn hàng gửi sang VNPAY. Không được trùng lặp trong ngày

             
                string paymentUrl = vnpay.CreateRequestUrl(vnp_Url, vnp_HashSecret);

                return Ok(new { PaymentUrl = paymentUrl });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPut("Order/Payment")]
        public async Task<IActionResult> UpdatePayment([FromBody] UpdatePaymentRequest request)
        {
            try
            {
                await _orderService.UpdatePayment(request);
                return Ok(new { message = "Payment success" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
      /*  [HttpGet("vnpay/ipn")]
        public async Task<IActionResult> HandleVNPayIpn()
        {
            string returnContent = string.Empty;
            try
            {
                if (Request.Query.Count > 0)
                {
                    var vnpayData = Request.Query;
                    VnPayLibrary vnpay = new VnPayLibrary();

                    foreach (var kvp in vnpayData)
                    {
                        if (!string.IsNullOrEmpty(kvp.Key) && kvp.Key.StartsWith("vnp_"))
                        {
                            vnpay.AddResponseData(kvp.Key, kvp.Value);
                        }
                    }

                    string vnp_OrderInfo = vnpay.GetResponseData("vnp_OrderInfo");
                    string orderId = vnp_OrderInfo.Split(":")[1];
                    *//*long orderId = Convert.ToInt64(vnpay.GetResponseData("vnp_TxnRef"));*//*
                    long vnp_Amount = Convert.ToInt64(vnpay.GetResponseData("vnp_Amount")) / 100;
                    long vnpayTranId = Convert.ToInt64(vnpay.GetResponseData("vnp_TransactionNo"));
                    string vnp_ResponseCode = vnpay.GetResponseData("vnp_ResponseCode");
                    string vnp_TransactionStatus = vnpay.GetResponseData("vnp_TransactionStatus");
                    string vnp_SecureHash = vnpay.GetResponseData("vnp_SecureHash");

                    bool checkSignature = vnpay.ValidateSignature(vnp_SecureHash, vnp_HashSecret);
                    if (checkSignature)
                    {
                        // Lấy thông tin đơn hàng từ DB
                        var order = await _orderService.GetOrderById(Guid.Parse(orderId));
             

                        if (order != null)
                        {
                            if (order.OrderTotalPrice == vnp_Amount)
                            {
                                if (order.OrderStatus == 1) // 1 là chờ xác nhận, 2 là chờ giao hàng, 3 đã giao
                                {
                                    if (vnp_ResponseCode == "00" && vnp_TransactionStatus == "00")
                                    {
                                        Console.WriteLine("Thanh toán thành công, OrderId={0}, VNPAY TranId={1}", orderId, vnpayTranId);
                                        order.OrderStatus = 2; // chuyển sang trạng thái chờ giao hàng
                                        order.PaymentStatus = "Success";
                                    }
                                    else
                                    {
                                        Console.WriteLine("Thanh toán lỗi, OrderId={0}, VNPAY TranId={1}, ResponseCode={2}", orderId, vnpayTranId, vnp_ResponseCode);
                                        order.OrderStatus = 0; // chuyển sang trạng thái hủy
                                        order.PaymentStatus = "Cancelled";
                                    }

                                    // TODO: Cập nhật trạng thái đơn hàng vào DB
                                    await _orderService.UpdateOrderAsync(order);


                                    returnContent = "{\"RspCode\":\"00\",\"Message\":\"Confirm Success\"}";
                                }
                                else
                                {
                                    returnContent = "{\"RspCode\":\"02\",\"Message\":\"Order already confirmed\"}";
                                }
                            }
                            else
                            {
                                returnContent = "{\"RspCode\":\"04\",\"Message\":\"Invalid amount\"}";
                            }
                        }
                        else
                        {
                            returnContent = "{\"RspCode\":\"01\",\"Message\":\"Order not found\"}";
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid signature, InputData={0}", Request.QueryString);
                        returnContent = "{\"RspCode\":\"97\",\"Message\":\"Invalid signature\"}";
                    }
                }
                else
                {
                    returnContent = "{\"RspCode\":\"99\",\"Message\":\"Input data required\"}";
                }

                return Content(returnContent, "application/json");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi xử lý IPN từ VNPAY");
                return Content("{\"RspCode\":\"99\",\"Message\":\"Internal Server Error\"}", "application/json");
            }
        }*/
    }

   
}
