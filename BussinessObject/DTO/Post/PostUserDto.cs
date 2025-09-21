using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BussinessObject.DTO.Post
{
    public class PostUserDto
    {
        public Guid UserId { get; set; }
        public string ProfileName { get; set; } = string.Empty;
        public string? UrlImage { get; set; }   
        public bool? IsFollowed { get; set; } = false;       
     
    }
}
