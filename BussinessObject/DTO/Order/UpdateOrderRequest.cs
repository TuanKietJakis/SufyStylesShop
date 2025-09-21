using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.DTO.Order
{
    public class UpdateOrderRequest
    {
        [Required]
        [StringLength(50, ErrorMessage = "Status cannot exceed 50 characters.")]
        public string Status { get; set; }

        [StringLength(100, ErrorMessage = "Reason cannot exceed 100 characters.")]
        public string? Reason { get; set; }
    }
    public class UpdatePaymentRequest
    {
        public Guid OrderId { get; set; }

        [StringLength(50, ErrorMessage = "PaymentStatus cannot exceed 50 characters.")]
        public string? PaymentStatus { get; set; }
    }
}
