using Microsoft.Extensions.Primitives;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BussinessObject.DTO.UserVoucher
{
    public class UserVoucherCreateDto
    {
        [SwaggerIgnore]
        public Guid UserId { get; set; }
        public int? DiscountValue { get; set; }
        public int? MinimumOrderValue { get; set; }
        [JsonConverter(typeof(DateTimeWithTimeConverter))]
        public DateTime? ExpiryDate { get; set; }
        [JsonConverter(typeof(DateTimeWithTimeConverter))]
        public DateTime? StartDate { get; set; }
        public int? MaxUsage { get; set; }
        [Required(ErrorMessage = "Description is required.")]
        [MaxLength(255, ErrorMessage = "Description cannot exceed 255 characters.")]
        public string? Description { get; set; }
        public bool IsActive { get; set; }

    }
    
}
