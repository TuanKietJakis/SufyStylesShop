using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BussinessObject.Models
{
    public class ProductVariant
    {
        [Key]
        public Guid VariantId { get; set; } = Guid.NewGuid();

        [Required]
        public Guid ProductId { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public double? Price { get; set; }

        [Required]
        public long Quantity { get; set; }

        [Required]
        [StringLength(150)]
        public string UrlImage { get; set; } = null!;

        [StringLength(20)]
        public string? Option1 { get; set; }

        [StringLength(20)]
        public string? Option2 { get; set; }

        [StringLength(20)]
        public string? Option3 { get; set; }

        [StringLength(20)]
        public string? OptionValue1 { get; set; }

        [StringLength(20)]
        public string? OptionValue2 { get; set; }

        [StringLength(20)]
        public string? OptionValue3 { get; set; }

        public bool IsDeleted { get; set; } = false;

        public virtual Product? Product { get; set; }
     
    }
}
//WooCommerce: WooCommerce cũng đặt các tùy chọn sản phẩm với các giới hạn từ 20 đến 100 ký tự cho các giá trị như màu sắc, kích cỡ.
