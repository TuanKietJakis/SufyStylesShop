using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.DTO.Comment
{
    public class CommentUserDto
    {
        public Guid UserId { get; set; }
        public string ProfileName { get; set; } = string.Empty;
        public string? UrlImage { get; set; }
    }
}
