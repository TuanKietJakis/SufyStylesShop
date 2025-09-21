using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.DTO.Product
{
    public class CreateProductVendorDto
    {
        [Required(ErrorMessage = "The Vendor Name field is required.")]
        [StringLength(100, ErrorMessage = "The Vendor Name cannot exceed 100 characters.")]
        public string ProductVendorName { get; set; } = null!;
        [Required(ErrorMessage = "The Vendor Logo field is required.")]
        [StringLength(150, ErrorMessage = "The URL of the Vendor Logo cannot exceed 150 characters.")]
        public string? UrlImage { get; set; }
    }
}
