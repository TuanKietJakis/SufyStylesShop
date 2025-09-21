using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BussinessObject.DTO.InfoPage
{
    public class UpdateFAQDto
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Category must not be empty.")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [MaxLength(255, ErrorMessage = "Category must not exceed 255 characters.")]
        public string? Category { get; set; }

        [Required(ErrorMessage = "Question must not be empty.")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [MaxLength(500, ErrorMessage = "Question must not exceed 500 characters.")]
        public string? Question { get; set; }

        [Required(ErrorMessage = "Answer must not be empty.")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [MaxLength(2000, ErrorMessage = "Answer must not exceed 2000 characters.")]
        public string? Answer { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IsDeleted { get; set; }

        [JsonIgnore]
        public Guid? UpdatedUserId { get; set; }
    }
}
