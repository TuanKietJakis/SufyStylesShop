using BussinessObject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BussinessObject.Models
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; } = Guid.NewGuid(); // (16 Bytes) GUID giúp đảm bảo ID duy nhất, phù hợp hệ thống phân tán.

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; } = string.Empty; // (200 Bytes) Tên sản phẩm, giới hạn 100 ký tự.

        [StringLength(1000)]
        public string? Description { get; set; } // (2000 Bytes nếu có dữ liệu) Mô tả sản phẩm, tránh lưu quá dài.

        [StringLength(60)]
        public string? PageTitle { get; set; } // (120 Bytes) Chuẩn SEO, giới hạn 60 ký tự theo khuyến nghị Google.

        [StringLength(160)]
        public string? MetaDescription { get; set; } // (320 Bytes) Chuẩn SEO, tối đa 160 ký tự cho mô tả meta.

        [StringLength(50)]
        public string? ProductTypeName { get; set; } // (100 Bytes) Loại sản phẩm, tránh trùng lặp dữ liệu.

        public Guid ProductVendorId { get; set; } // (16 Bytes) ID của nhà cung cấp.

        [StringLength(200)]
        public string ProductUrl { get; set; } // (400 Bytes) URL sản phẩm, đủ chứa tên + tham số.

        public bool IsVisible { get; set; } = true; // (1 Byte) Trạng thái hiển thị sản phẩm.

        public DateTime? CreateDate { get; set; } // (8 Bytes) Ngày tạo sản phẩm.
        public DateTime? UpdateDate { get; set; } // (8 Bytes) Ngày cập nhật sản phẩm.

        [Range(0, 100)]
        public double? SalePricePercent { get; set; } = 0; // (8 Bytes) % giảm giá, giá trị từ 0-100.

        public bool IsDeleted { get; set; } = false; // (1 Byte) Trạng thái sản phẩm có bị xóa không.

        public Guid UserId { get; set; } // (16 Bytes) ID của người dùng liên kết với sản phẩm.

        [StringLength(150)]
        public string? UrlImage { get; set; } // (Tùy kích thước) Đường dẫn hình ảnh sản phẩm.

        [StringLength(100)]
        public string? AltText { get; set; } // (250 Bytes) Chuẩn SEO và hỗ trợ Accessibility.

        public bool? IsFeatured { get; set; } // (1 Byte) Sản phẩm có được đánh dấu nổi bật không.

        // Quan hệ với các bảng khác
        public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
        public virtual ICollection<ProductFeedback> ProductFeedbacks { get; set; } = new List<ProductFeedback>();
        public virtual ICollection<ProductVariant> ProductVariants { get; set; } = new List<ProductVariant>();
        public virtual ProductVendor? ProductVendor { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
   
        public virtual ICollection<UserWishList> WishLists { get; set; } = new List<UserWishList>();
        public virtual ICollection<PostProductTag> PostProductTags { get; set; } = new List<PostProductTag>();
    }
}
