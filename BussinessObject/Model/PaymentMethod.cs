using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BussinessObject.Models
{
    public class PaymentMethod
    {
        [Key]
        public Guid PaymentMethodId { get; set; } = Guid.NewGuid();

        [Required] 
        [StringLength(20)]
        public string PaymentName { get; set; } = string.Empty;

        public bool IsDeleted { get; set; } = false;

    }
}

/*Thẻ tín dụng:
Ví dụ: Visa, MasterCard, American Express (tất cả đều dưới 20 ký tự).
Các dịch vụ thanh toán trực tuyến:
PayPal(6 ký tự)
Stripe(6 ký tự)
Google Pay(10 ký tự)
Apple Pay(9 ký tự)
Alipay(6 ký tự)
Phương thức thanh toán qua ngân hàng:
Bank Transfer(13 ký tự)
Direct Debit(12 ký tự)*/
