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
    public class ProductFeedback
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ProductFeedbackId { get; set; }

        [Required]
        public Guid ProductId { get; set; } 

        [Required]
        public Guid UserId { get; set; } 

        [Required]
        [StringLength(500)]
        public string Content { get; set; } = string.Empty; 

        [Range(1, 5)]
        public int Rating { get; set; } 

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public bool IsFinished { get; set; } = false;
        public bool IsDeleted { get; set; } = false;

        public bool IsReported { get; set; } = false ;

        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }
    }
}

/*Giới hạn 500 - 1000 ký tự cho phần Content của ProductFeedback là hợp lý và phổ biến trong các hệ thống thương mại điện tử như Shopee. Bạn có thể cân nhắc áp dụng giới hạn này tùy thuộc vào yêu cầu cụ thể của hệ thống của bạn.*/
