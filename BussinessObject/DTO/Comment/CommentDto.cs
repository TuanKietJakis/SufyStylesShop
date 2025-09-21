using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.DTO.Comment
{
    public class CommentDto
    {
        public Guid PostCommentId { get; set; }
        public Guid PostId { get; set; }
        public Guid UserId { get; set; }
        public string? Content { get; set; }
        public DateTime CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public bool IsDeleted { get; set; } = false;
        public bool IsReported { get; set; }

        public long LikeNumber { get; set; } = 0;
        public List<CommentUserDto> LikedUsers { get; set; } = new List<CommentUserDto>();
        public CommentUserDto User { get; set; }
    }
}
