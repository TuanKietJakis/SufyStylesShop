using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BussinessObject.DTO.InfoPage
{
    public class UpdateBannerDto
    {
        public Guid Id { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [MaxLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string? Name { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [MaxLength(150, ErrorMessage = "URL Image cannot exceed 150 characters.")]
        public string? UrlImage { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IsVisible { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [MaxLength(10, ErrorMessage = "Position cannot exceed 10 characters.")]
        public string? Position { get; set; }

        [JsonIgnore]
        public Guid? UserId { get; set; }
    }

    public class UpdateContactFormDto
    {
        public Guid Id { get; set; }

        public bool IsFinished { get; set; }

        [JsonIgnore]
        public Guid? UserId { get; set; }
    }
}
