using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.DTO.Product
{
    public class ProductDetailDTO
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? PageTitle { get; set; }
        public string? MetaDescription { get; set; }
        public string? ProductTypeName { get; set; }
        public string ProductUrl { get; set; }
        public bool IsVisible { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public double? SalePricePercent { get; set; }
        public bool IsDeleted { get; set; }
        public string ProductVendorName { get; set; } = string.Empty;
       
        public string UrlImage { get; set; } = null!;
        public string? AltText { get; set; }
        public bool? IsFeatured { get; set; }
        public List<ProductVariantDTO> ProductVariants { get; set; } = new List<ProductVariantDTO>();
        public List<ProductFeedbackDTO> ProductFeedbacks { get; set; } = new List<ProductFeedbackDTO>();
    }

    public class ProductVariantDTO
    {
        public Guid VariantId { get; set; }
        public double? Price { get; set; }
        public long? Quantity { get; set; }
        public string UrlImage { get; set; } = string.Empty;
        public string? Option1 { get; set; }
        public string? Option2 { get; set; }
        public string? Option3 { get; set; }
        public string? OptionValue1 { get; set; }
        public string? OptionValue2 { get; set; }
        public string? OptionValue3 { get; set; }
    }

    public class ProductFeedbackDTO
    {
        public Guid FeedbackId { get; set; }
        public Guid UserId { get; set; }
        public string Content { get; set; } = string.Empty;
        public int Rating { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UserFullName { get; set; } = string.Empty;
    }

    public class ProductDetailStaffDTO
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? PageTitle { get; set; }
        public string? MetaDescription { get; set; }
        public string? ProductTypeName { get; set; }
        public string ProductUrl { get; set; }
        public bool IsVisible { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public double? SalePricePercent { get; set; }
        public bool IsDeleted { get; set; }

        public string ProductVendorName { get; set; } = string.Empty;

        public string UrlImage { get; set; } = null!;
        public string? AltText { get; set; }
        public bool? IsFeatured { get; set; }
        public List<ProductVariantDTO> ProductVariants { get; set; } = new List<ProductVariantDTO>();
      
    }

}
