using BussinessObject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BussinessObject.Models
{
    public class PostComment
    {
        // PostCommentId: ID của bình luận, kiểu Guid, chiếm 16 byte
        public Guid PostCommentId { get; set; } = Guid.NewGuid();

        // PostId: ID bài viết mà bình luận thuộc về, kiểu Guid, chiếm 16 byte
        public Guid PostId { get; set; }

        // UserId: ID người dùng thực hiện bình luận, kiểu Guid, chiếm 16 byte
        public Guid UserId { get; set; }

        // Content: Nội dung bình luận, giới hạn 1000 ký tự (1000 * 2 byte = 2000 byte nếu trung bình mỗi ký tự chiếm 2 byte)
        [Required]
        [StringLength(1000)]
        public string Content { get; set; }

        // CreateDate: Thời gian tạo bình luận, kiểu DateTime, chiếm 8 byte
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;

        // UpdateDate: Thời gian cập nhật bình luận, kiểu DateTime, chiếm 8 byte
        public DateTime UpdateDate { get; set; } = DateTime.UtcNow;

        // LikeNumber: Số lượng thích của bình luận, kiểu long, chiếm 8 byte
        public long LikeNumber { get; set; } = 0;

        // PostCommentLikes: Các lượt thích bình luận, kiểu ICollection<PostCommentLike>, phụ thuộc vào số lượt thích thực tế
        public virtual ICollection<PostCommentLike> PostCommentLikes { get; set; } = new List<PostCommentLike>();

        // IsDeleted: Trạng thái có bị xóa không, kiểu bool, chiếm 1 byte
        public bool IsDeleted { get; set; } = false;

        // IsReported: Trạng thái có bị báo cáo không, kiểu bool, chiếm 1 byte
        public bool IsReported { get; set; } = false;

        // Post: Liên kết đến bài viết mà bình luận thuộc về
        public virtual Post? Post { get; set; }

        // User: Liên kết đến người dùng thực hiện bình luận
        public virtual User? User { get; set; }
    }
}
