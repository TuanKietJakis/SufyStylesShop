using BussinessObject.DTO.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.DTO.Cart
{
    public class CartItemDto
    {
        public Guid CartItemId { get; set; }
        public Guid ProductId { get; set; }
        public Guid VariantId { get; set; }
        public string ProductName { get; set; }
        public string ProductUrl { get; set; }
      
        public double? SalePricePercent { get; set; }
        public string UrlImage { get; set; } = null!;
        public double? Price { get; set; }
        public long? Quantity { get; set; }
        public long? MaxQuantity { get; set; }
        public string? Option1 { get; set; }
        public string? Option2 { get; set; }
        public string? Option3 { get; set; }
        public string? OptionValue1 { get; set; }
        public string? OptionValue2 { get; set; }
        public string? OptionValue3 { get; set; }
        public string? ProductVendorName { get; set; }
    }
}
