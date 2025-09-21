using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.DTO.Post
{
    public class PostBookmarkDto
    {
        public Guid UserId { get; set; }
        public Guid PostId { get; set; }
        public DateTime SaveDate { get; set; } = DateTime.Now;

        public bool IsDeleted { get; set; } = false;

        public PostDto? Post { get; set; }
    }
}
