using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BussinessObject.DTO.Post
{
    public class PostUpdateDto
    {
        [StringLength(255, ErrorMessage = "Title cannot exceed 255 characters.")]
        public string? Title { get; set; }

        [StringLength(1000, ErrorMessage = "Content cannot exceed 1000 characters.")]
        public string? Content { get; set; }

        [StringLength(60, ErrorMessage = "PageTitle cannot exceed 60 characters.")]
        public string? PageTitle { get; set; }

        [StringLength(160, ErrorMessage = "MetaDescription cannot exceed 160 characters.")]
        public string? MetaDescription { get; set; }

        [StringLength(200, ErrorMessage = "UrlHandle cannot exceed 200 characters.")]
        public string? UrlHandle { get; set; }

        public bool? IsVisible { get; set; }

        public List<ImagePostUpdateDto>? ImagePostsDto { get; set; }
    }

    public class ImagePostUpdateDto
    {
        [StringLength(10, ErrorMessage = "AspectRatio cannot exceed 10 characters.")]
        public string? AspectRatio { get; set; }

        [StringLength(100, ErrorMessage = "AltImage cannot exceed 100 characters.")]
        public string? AltImage { get; set; }

        [StringLength(150, ErrorMessage = "UrlImage cannot exceed 150 characters.")]
        public string? UrlImage { get; set; }
    }
}
