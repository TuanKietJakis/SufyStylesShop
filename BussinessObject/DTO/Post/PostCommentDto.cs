using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BussinessObject.DTO.Post
{
    public class PostCommentDto
    {
        public Guid PostCommentId { get; set; }
        public Guid PostId { get; set; }
        public Guid UserId { get; set; }
        public string ProfileName { get; set; } = string.Empty;
        public string? UrlImage { get; set; }
        public string? Content { get; set; }
        public DateTime CreateDate { get; set; } 

        public DateTime? UpdateDate { get; set; }

        public bool IsDeleted { get; set; } = false;

        public long LikeNumber { get; set; } = 0;
        public bool CanLike { get; set; } = true;
        public bool IsFollow { get; set; } = false;
    }
}