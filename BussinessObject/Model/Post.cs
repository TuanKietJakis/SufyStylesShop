using BussinessObject.DTO.Post;

using BussinessObject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BussinessObject.Models
{
    public class Post
    {
        public static Post Create(PostCreateDto dto)
        {
            if (string.IsNullOrEmpty(dto.Title) || string.IsNullOrEmpty(dto.Content))
            {
                throw new ArgumentException("Title and Content are required.");
            }

            var datetime = DateTime.Now;

            var post = new Post()
            {
                PostId = Guid.NewGuid(),
                AuthorId = dto.AuthorId,
                Title = dto.Title,
                Content = dto.Content,
                PageTitle = dto.PageTitle,
                MetaDescription = dto.MetaDescription,
                UrlHandle = dto.UrlHandle,
                IsVisible = dto.IsVisible ?? null,
                CreateDate = datetime,
                UpdateDate = datetime
            };

            if (dto.ImagePosts?.Any() == true)
            {
                foreach (var imageDto in dto.ImagePosts)
                {
                    if (string.IsNullOrEmpty(imageDto.UrlImage))
                    {
                        throw new ArgumentException("UrlImage is required.");
                    }

                    var imagePost = new PostImage
                    {
                        AspectRatio = imageDto.AspectRatio,
                        AltImage = imageDto.AltImage,
                        UrlImage = imageDto.UrlImage,
                        PostId = post.PostId
                    };

                    post.PostImages.Add(imagePost);
                }
            }

            if (dto.PostProductTags?.Any() == true)
            {
                foreach (var productTagDto in dto.PostProductTags)
                {
                    var postProductTag = new PostProductTag
                    {
                        PostProductTagId = Guid.NewGuid(),
                        ProductId = (Guid)productTagDto.ProductId,
                        UrlImage = productTagDto.UrlImage,
                        ProductName = productTagDto.ProductName,
                        PostId = post.PostId
                    };

                    post.PostProductTags.Add(postProductTag);
                }
            }

            return post;
        }

        [Key]
        public Guid PostId { get; set; } = Guid.NewGuid(); // (16 bytes) Mã định danh duy nhất cho bài đăng

        public Guid AuthorId { get; set; } // (16 bytes) ID của tác giả bài đăng

        [Required]
        [StringLength(255)] // Tiêu đề bài viết - tối đa 255 ký tự (Facebook hỗ trợ tiêu đề dài)
        public required string Title { get; set; } // (2 * 255 bytes) 

        [Required]
        [StringLength(1000)]
        public required string Content { get; set; } // Nội dung bài đăng (Dung lượng tùy thuộc vào nội dung)

        [StringLength(60)] // Giới hạn theo chuẩn SEO (Google khuyến nghị < 60 ký tự)
        public string? PageTitle { get; set; } // (2 * 60 bytes)  

        [StringLength(160)] // Chuẩn SEO Meta Description (Google khuyến nghị < 160 ký tự)
        public string? MetaDescription { get; set; } // (2 * 160 bytes)  

        public int ViewNumber { get; set; } = 0; // (4 bytes) Số lượt xem bài viết


        [StringLength(200)] // URL thân thiện SEO (VD: example.com/blog/my-post)
        public string? UrlHandle { get; set; } // (2 * 200 bytes)  

        public DateTime CreateDate { get; set; } = DateTime.Now; // (8 bytes) Ngày tạo bài viết

        public DateTime UpdateDate { get; set; } = DateTime.Now; // (8 bytes) Ngày cập nhật bài viết

        public bool? IsVisible { get; set; } // (1 byte) Bài viết có hiển thị không?

        public bool IsDeleted { get; set; } = false; // (1 byte) Trạng thái xóa mềm

        public bool? IsReported { get; set; } // (1 byte) Bài viết có bị báo cáo không?

        [StringLength(50)] // Lý do báo cáo giới hạn 500 ký tự
        public string? ReasonReport { get; set; } // (2 * 500 bytes)  

        // Quan hệ với bảng User (Tác giả)
        [ForeignKey("AuthorId")]
        public virtual User? Author { get; set; }

        // Danh sách lượt thích bài viết
        public virtual ICollection<PostLike> PostLikes { get; set; } = new List<PostLike>();

        // Danh sách bình luận bài viết
        public virtual ICollection<PostComment> PostComments { get; set; } = new List<PostComment>();

        // Danh sách người lưu bài viết vào bookmark
        public virtual ICollection<PostBookmark> PostBookmarks { get; set; } = new List<PostBookmark>();

        // Danh sách hình ảnh đính kèm bài viết
        public virtual ICollection<PostImage> PostImages { get; set; } = new List<PostImage>();

        // Danh sách tag sản phẩm trong bài viết
        public virtual ICollection<PostProductTag> PostProductTags { get; set; } = new List<PostProductTag>();
    }
}


/*Thuộc tính	Kích thước (byte)
PostId	16
AuthorId	16
Title	510
Content	2000
PageTitle	120
MetaDescription	320
ViewNumber	4
ShareNumber	4
UrlHandle	400
CreateDate	8
UpdateDate	8
IsVisible	1
IsDeleted	1
IsReported	1
ReasonReport	1000
Tổng cộng	4409 byte*/
// thực tế 4.3kb
