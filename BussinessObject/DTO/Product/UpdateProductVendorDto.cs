using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BussinessObject.DTO.Product
{
    public class UpdateProductVendorDto
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [StringLength(100, ErrorMessage = "The Vendor Name cannot exceed 100 characters.")]
        public string? ProductVendorName { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [StringLength(150, ErrorMessage = "The Vendor Logo field is required.")]
        public string? UrlImage { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IsDeleted { get; set; }
    }
}
