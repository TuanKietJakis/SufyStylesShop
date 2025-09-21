using BussinessObject.DTO.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.DTO.Cart
{
    public class ProductUpdateCart
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string UrlImage { get; set; } = null!;
       
        public List<ProductVariantDTO> ProductVariants { get; set; } = new List<ProductVariantDTO>();
    }
}
