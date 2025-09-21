using BussinessObject.Model;
using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.DTO.UserVoucher
{
    public class UserVoucherDto
    {
        public Guid? VoucherId { get; set; }
        public Guid? UserCreateId { get; set; }
        public int? DiscountValue { get; set; }
        public int? MinimumOrderValue { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime? StartDate { get; set; }
        public bool? IsActive { get; set; }
        public int? CurrentUsage { get; set; } 
        public int? MaxUsage { get; set; }
        public string? Description { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
