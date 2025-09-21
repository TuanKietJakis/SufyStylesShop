using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.DTO.Product
{
    public class ProductVendorDto
    {
        public Guid ProductVendorId { get; set; }

        public string ProductVendorName { get; set; }

        public string? UrlImage { get; set; }

        public bool IsDeleted { get; set; } 
    }
}
