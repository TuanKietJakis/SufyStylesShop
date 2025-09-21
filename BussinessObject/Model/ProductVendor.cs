using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BussinessObject.Models
{
    public class ProductVendor
    {
        [Key]
        public Guid ProductVendorId { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(100)]
        public string ProductVendorName { get; set; } = null!;

        [StringLength(150)]
        public string? UrlImage { get; set; }

        public DateTime? SaveDate { get; set; }

        public bool IsDeleted { get; set; } = false;

        public virtual ICollection<Product>? Products { get; set; } = new List<Product>();

    }
}

// Shopify: Hầu hết các tên nhà cung cấp và thương hiệu trên các nền tảng như Shopify thường có giới hạn trong khoảng 50 đến 100 ký tự, đủ để chứa các tên thương hiệu phổ biến mà không quá dài.
