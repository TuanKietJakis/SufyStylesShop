using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BussinessObject.DTO.Product
{
    public class ProductVariantRequest
    {   
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
        public double? Price { get; set; }
       
        [Range(1, long.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
        public long? Quantity { get; set; }
 
        [Required(ErrorMessage = "Image URL is required.")]
        [StringLength(150, ErrorMessage = "Image URL cannot exceed 150 characters.")]
        public string? UrlImage { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [StringLength(20, ErrorMessage = "Option1 cannot exceed 20 characters.")]
        public string? Option1 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [StringLength(20, ErrorMessage = "Option2 cannot exceed 20 characters.")]
        public string? Option2 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [StringLength(20, ErrorMessage = "Option3 cannot exceed 20 characters.")]
        public string? Option3 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [StringLength(20, ErrorMessage = "Option value1 cannot exceed 20 characters.")]
        public string? OptionValue1 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [StringLength(20, ErrorMessage = "Option value2 cannot exceed 20 characters.")]
        public string? OptionValue2 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [StringLength(20, ErrorMessage = "Option value3 cannot exceed 20 characters.")]
        public string? OptionValue3 { get; set; }
    }

}
