using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.Model
{
    public class PostCommentLike
    {
        public Guid UserId { get; set; }
        public virtual User? User { get; set; }

        public Guid CommentId { get; set; }
        public virtual PostComment? PostComment { get; set; }

        public DateTime LikedDate { get; set; } = DateTime.UtcNow;
        public bool IsDeleted { get; set; } = false;
    }
}
