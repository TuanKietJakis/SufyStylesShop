using BussinessObject.DTO.Post;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace BussinessObject.Models
{
    public class PostImage
    {
        public static PostImage Create(Guid postId, ImagePostUpdateDto dto)
        {
            if (string.IsNullOrEmpty(dto.UrlImage))
            {
                throw new ArgumentException("UrlImage are required.");
            }

            return new PostImage
            {
                ImagePostId = Guid.NewGuid(),
                PostId = postId,
                AspectRatio = dto.AspectRatio,
                AltImage = dto.AltImage,
                UrlImage = dto.UrlImage
            };
        }
        [Key]
        public Guid ImagePostId { get; set; } = Guid.NewGuid();
        public Guid? PostId { get; set; }
        // Tỷ lệ phổ biến: Các tỷ lệ khung hình thông dụng như 16:9, 4:3, 1:1, 2.39:1, v.v. không dài quá 10 ký tự.
        [StringLength(10)]
        public string? AspectRatio { get; set; }
        /* 100 ký tự là một giới hạn phổ biến cho Alt text trong các quy ước về thiết kế web.Đây là giới hạn tối ưu để đảm bảo văn bản mô tả đủ thông tin nhưng không quá dài, tránh làm người dùng cảm thấy quá tải.
 255 ký tự là mức độ dài tối đa mà bạn có thể sử dụng cho Alt text, tùy thuộc vào yêu cầu của từng công cụ tìm kiếm và môi trường thực tế.*/

       /* Theo W3C, họ khuyến nghị rằng các hình ảnh cần có văn bản thay thế ngắn gọn và dễ hiểu.
WCAG(Web Content Accessibility Guidelines) khuyến cáo rằng Alt text phải ngắn gọn, dễ hiểu, mô tả được mục đích và nội dung của hình ảnh.*/
        [StringLength(100)]
        public string? AltImage { get; set; }
        [StringLength(150)]
        public required string UrlImage { get; set; }
        public virtual Post? Post { get; set; }
    }
}
