using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BussinessObject.DTO.Post
{
    public class PostCreateDto
    {
        public Guid AuthorId { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [StringLength(255, ErrorMessage = "Title cannot exceed 255 characters.")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Content is required.")]
        [StringLength(1000, ErrorMessage = "Content cannot exceed 1000 characters.")]
        public string? Content { get; set; }

        [StringLength(60, ErrorMessage = "PageTitle cannot exceed 60 characters.")]
        public string? PageTitle { get; set; }

        [StringLength(160, ErrorMessage = "MetaDescription cannot exceed 160 characters.")]
        public string? MetaDescription { get; set; }

        [StringLength(200, ErrorMessage = "UrlHandle cannot exceed 200 characters.")]
        public string? UrlHandle { get; set; }

        public bool? IsVisible { get; set; } = null;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<PostImageCreateDto>? ImagePosts { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<PostProductTagCreateDto>? PostProductTags { get; set; }
    }

    public class PostProductTagCreateDto
    {
        public Guid ProductId { get; set; }

        [StringLength(100, ErrorMessage = "ProductName cannot exceed 100 characters.")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ProductName { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [StringLength(150, ErrorMessage = "UrlImage cannot exceed 150 characters.")]
        public string? UrlImage { get; set; }
    }

    public class PostImageCreateDto
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [StringLength(10, ErrorMessage = "AspectRatio cannot exceed 10 characters.")]
        public string? AspectRatio { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [StringLength(100, ErrorMessage = "AltImage cannot exceed 10 characters.")]
        public string? AltImage { get; set; }

        [Required(ErrorMessage = "UrlImage is required.")]
        [StringLength(150, ErrorMessage = "UrlImage cannot exceed 150 characters.")]
        public string? UrlImage { get; set; }
    }
}
