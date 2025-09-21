using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BussinessObject.DTO.Order
{
    public class UpdateAddressOrder
    {
        public Guid OrderId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [StringLength(255, ErrorMessage = "Address cannot exceed 255 characters.")]
        public string? Address { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [RegularExpression(@"^0\d{9}$", ErrorMessage = "Phone number must start with 0 and have exactly 10 digits.")]
        public string Phone { get; set; }


        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [StringLength(50, ErrorMessage = "Fullname cannot exceed 50 characters.")]
        public string? Fullname { get; set; }
    }
}
