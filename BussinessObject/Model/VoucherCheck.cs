using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.Model
{
    public class VoucherCheck
    {
        [Key]
        public Guid VoucherCheckId { get; set; } = Guid.NewGuid();

        [Required]
        public Guid VoucherId { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public DateTime UseDate { get; set; }

        // Navigation properties
        [ForeignKey(nameof(VoucherId))]
        public virtual UserVoucher UserVoucher { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; } = null!;
    }
}
