using Swashbuckle.AspNetCore.Annotations;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BussinessObject.DTO.UserVoucher
{
    public class UserVoucherUpdateDto
    {
        [SwaggerIgnore]
        public Guid VoucherId { get; set; }

        [SwaggerIgnore]
        public Guid UserId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Discount value must be a positive number.")]
        public int? DiscountValue { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Minimum order value must be a positive number.")]
        public int? MinimumOrderValue { get; set; }

        [JsonConverter(typeof(DateTimeWithTimeConverter))]
        public DateTime? ExpiryDate { get; set; }

        [JsonConverter(typeof(DateTimeWithTimeConverter))]
        public DateTime? StartDate { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Max usage must be greater than 0.")]
        public int? MaxUsage { get; set; }

        [StringLength(255, ErrorMessage = "Description cannot exceed 255 characters.")]
        [Required(ErrorMessage = "Description is required.")]
        public string? Description { get; set; }

        public bool IsActive { get; set; }
    }
}
