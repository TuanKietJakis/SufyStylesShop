using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BussinessObject.DTO.Order
{
    public class OrderCreateRequest
    {
        [JsonIgnore]
        [Required(ErrorMessage = "UserId is required.")]
        public Guid UserId { get; set; }

        [Required(ErrorMessage = "PaymentMethodId is required.")]
        public Guid PaymentMethodId { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [StringLength(255, ErrorMessage = "Address must not exceed 255 characters.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Fullname is required.")]
        [StringLength(50, ErrorMessage = "Fullname must not exceed 50 characters.")]
        public string Fullname { get; set; }

        [Phone(ErrorMessage = "Invalid phone number format.")]
        [RegularExpression(@"^0\d{9}$", ErrorMessage = "Phone number must start with 0 and have exactly 10 digits.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "OrderStatus is required.")]
        public int OrderStatus { get; set; } = 0; // 0: Cancel

        [Required]
        [StringLength(50, ErrorMessage = "PaymentStatus must not exceed 50 characters.")]
        public string PaymentStatus { get; set; } = "Cash on Delivery";

        public Guid? VoucherId { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "OrderShippingFee must be a positive number.")]
        public double OrderShippingFee { get; set; }

        [Required(ErrorMessage = "At least one order detail is required.")]
        [MinLength(1, ErrorMessage = "Order must contain at least one item.")]
        public List<OrderDetailRequest> OrderDetails { get; set; } = new List<OrderDetailRequest>();
    }

    public class OrderDetailRequest
    {
        [Required(ErrorMessage = "VariantId is required.")]
        public Guid VariantId { get; set; }

        [Required(ErrorMessage = "Quantity is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
        public int Quantity { get; set; }
    }
}
