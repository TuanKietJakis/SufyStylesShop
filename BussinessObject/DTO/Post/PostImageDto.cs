using System.ComponentModel.DataAnnotations;

namespace BussinessObject.DTO.Post
{
    public class PostImageDto
    {
        public Guid ImagePostId { get; set; }
        public Guid PostId { get; set; }
        public string? AspectRatio { get; set; }
        public string? AltImage { get; set; }
        public string UrlImage { get; set; } = string.Empty;
    }
}