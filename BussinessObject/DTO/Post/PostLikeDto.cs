using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.DTO.Post
{
    public class PostLikeDto
    {
        public Guid UserId { get; set; }
        public Guid PostId { get; set; }
        public PostUserDto? User { get; set; }
        public bool IsDeleted { get; set; }
    } 
    public class PostLikeAdminDto
    {
        public Guid UserId { get; set; }
        public Guid PostId { get; set; }
        public string ProfileName { get; set; } = string.Empty;
        public string? UrlImage { get; set; }
        public bool IsDeleted { get; set; }
    }
}
