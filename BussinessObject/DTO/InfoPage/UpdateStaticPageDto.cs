using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BussinessObject.DTO.InfoPage
{
    public class UpdateStaticPageDto
    {
        public Guid Id { get; set; }
      
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [MaxLength(50, ErrorMessage = "Title cannot exceed 50 characters.")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Content must not be empty.")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [MaxLength(4000, ErrorMessage = "Content must not exceed 4000 characters.")]
        public string? Content { get; set; }

        [JsonIgnore]
        public Guid? UpdatedUserId { get; set; }
    }
}
