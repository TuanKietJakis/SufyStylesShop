using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BussinessObject.Models
{
    public class Order
    {
        [Key]
        public Guid OrderId { get; set; } = Guid.NewGuid();

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public Guid PaymentMethodId { get; set; }

        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        public Guid? ComfirmUserId { get; set; }

        public DateTime? CreatedDate { get; set; } = DateTime.Now;

        [Required]
        [StringLength(50)]
        public string? PaymentStatus { get; set; }


        [Required]
        [StringLength(50)]
        public string Fullname { get; set; } = string.Empty;
        [Required]
        public int? OrderStatus { get; set; } // 0 cancel, 

        public double? OrderShippingFee { get; set; }

        public double? SubTotal { get; set; }

        public DateTime? CancelDate { get; set; }

        public double? OrderTotalPrice { get; set; }

        public DateTime? ComfirmDate { get; set; }

        [Phone]
        [StringLength(10)]
        public string? Phone { get; set; }
        [StringLength(100)]
        public string? ReasonCancel { get; set; }      

        public virtual PaymentMethod PaymentMethod { get; set; } = null!;

        public virtual User User { get; set; } = null!;
        [ForeignKey("ComfirmUserId")]
        public virtual User? Staff { get; set; }

        public virtual ICollection<OrderedDetail> OrderDetails { get; set; } = new List<OrderedDetail>();

    }
}
