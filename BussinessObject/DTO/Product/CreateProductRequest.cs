using BussinessObject.DTO.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class CreateProductRequest
{
    [Required(ErrorMessage = "Product name is required.")]
    [StringLength(100, ErrorMessage = "Product name cannot exceed 100 characters.")]
    public string ProductName { get; set; }

    [StringLength(1000, ErrorMessage = "Description cannot exceed 1000 characters.")]
    public string Description { get; set; }

    [StringLength(60, ErrorMessage = "Page title cannot exceed 60 characters.")]
    public string PageTitle { get; set; }

    [StringLength(160, ErrorMessage = "Meta description cannot exceed 160 characters.")]
    public string MetaDescription { get; set; }

    [Required(ErrorMessage = "Product type name is required.")]
    [StringLength(50, ErrorMessage = "Product type name cannot exceed 50 characters.")]
    public string ProductTypeName { get; set; }

    [Required(ErrorMessage = "Product vendor ID is required.")]
    public Guid ProductVendorId { get; set; }

    [StringLength(200, ErrorMessage = "Product URL cannot exceed 200 characters.")]
    public string ProductUrl { get; set; }

    public bool IsVisible { get; set; } = true;

    [Range(0, 100, ErrorMessage = "Sale price percent must be between 0 and 100.")]
    public double? SalePricePercent { get; set; }

    [StringLength(150, ErrorMessage = "Image URL cannot exceed 150 characters.")]
    public string? UrlImage { get; set; }

    [StringLength(100, ErrorMessage = "Alt text cannot exceed 100 characters.")]
    public string? AltText { get; set; }

    public bool? IsFeatured { get; set; }

    public List<ProductVariantRequest> ProductVariants { get; set; }
}
