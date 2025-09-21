
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.DTO.Product
{
    public class ProductDto
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string? Description { get; set; }
        public string? PageTitle { get; set; }
        public string? MetaDescription { get; set; }
        public string? ProductTypeName { get; set; }
        public string ProductUrl { get; set; }
        public bool IsVisible { get; set; }
        public double? SalePricePercent { get; set; }
        public bool IsDeleted { get; set; }
        public Guid ProductVendorId { get; set; }
        public string? ProductVendorName { get; set; }
        public string? ProductVendorUrlImage { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UrlImage { get; set; } = null!;
        public string? AltText { get; set; }
        public bool? IsFeatured { get; set; }

        public double Price { get; set; }
    }
     public class ProductStaffDto
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string? Description { get; set; }
        public string? PageTitle { get; set; }
        public string? MetaDescription { get; set; }
        public string? ProductTypeName { get; set; }
        public string ProductUrl { get; set; }
        public bool IsVisible { get; set; }
        public double? SalePricePercent { get; set; }
        public bool IsDeleted { get; set; }
        public Guid ProductVendorId { get; set; }
        public string? ProductVendorName { get; set; }
        public string? ProductVendorUrlImage { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UrlImage { get; set; } = null!;
        public string? AltText { get; set; }
        public bool? IsFeatured { get; set; }
        public List<ProductVariantDTO> ProductVariants { get; set; } = new List<ProductVariantDTO>();

    
    }


}
