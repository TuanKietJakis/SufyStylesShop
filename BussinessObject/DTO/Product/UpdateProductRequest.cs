using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BussinessObject.DTO.Product
{
    public class UpdateProductRequest
    {
        [Required(ErrorMessage = "ProductId is required.")]
        public Guid ProductId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [StringLength(100, ErrorMessage = "Product name cannot exceed 100 characters.")]
        public string? ProductName { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [StringLength(1000, ErrorMessage = "Description cannot exceed 1000 characters.")]
        public string? Description { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [StringLength(60, ErrorMessage = "Page title cannot exceed 60 characters.")]
        public string? PageTitle { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [StringLength(160, ErrorMessage = "Meta description cannot exceed 160 characters.")]
        public string? MetaDescription { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [StringLength(50, ErrorMessage = "Product type name cannot exceed 50 characters.")]
        public string? ProductTypeName { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Guid? ProductVendorId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [StringLength(200, ErrorMessage = "Product URL cannot exceed 200 characters.")]
        public string? ProductUrl { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IsVisible { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [Range(0, 100, ErrorMessage = "Sale price percent must be between 0 and 100.")]
        public double? SalePricePercent { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [StringLength(150, ErrorMessage = "Image URL cannot exceed 150 characters.")]
        public string? UrlImage { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [StringLength(100, ErrorMessage = "Alt text cannot exceed 100 characters.")]
        public string? AltText { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IsFeatured { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<UpdateProductVariantDto> ProductVariants { get; set; } = new();
    }

    public class UpdateProductVariantDto
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Guid? VariantId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
        public double? Price { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [Range(1, long.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
        public long? Quantity { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [Required(ErrorMessage = "Image URL is required.")]
        [StringLength(150, ErrorMessage = "Image URL cannot exceed 150 characters.")]
        public string? UrlImage { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [StringLength(20, ErrorMessage = "Option 1 cannot exceed 20 characters.")]
        public string? Option1 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [StringLength(20, ErrorMessage = "Option 2 cannot exceed 20 characters.")]
        public string? Option2 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [StringLength(20, ErrorMessage = "Option 3 cannot exceed 20 characters.")]
        public string? Option3 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [StringLength(20, ErrorMessage = "Option value 1 cannot exceed 20 characters.")]
        public string? OptionValue1 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [StringLength(20, ErrorMessage = "Option value 2 cannot exceed 20 characters.")]
        public string? OptionValue2 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [StringLength(20, ErrorMessage = "Option value 3 cannot exceed 20 characters.")]
        public string? OptionValue3 { get; set; }
    }
}
