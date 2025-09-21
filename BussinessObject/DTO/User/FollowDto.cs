using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.DTO.User
{
    public class FollowDto
    {
        public Guid UserId { get; set; } 
        public string Username { get; set; } = string.Empty;
        public string ProfileName { get; set; } = string.Empty;
        public string UrlImage { get; set; } = string.Empty;
        public DateTime? FollowDate { get; set; }
       
        public bool IsDeleted { get; set; }
    }
}
