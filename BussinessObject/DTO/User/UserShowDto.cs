using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BussinessObject.DTO.User
{
    public class UserShowDto
    {
        public Guid UserId { get; set; }
        public string ProfileName { get; set; }
        public string Email { get; set; }
        public string UrlImage { get; set; }     
        public string Phone { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public bool? Gender { get; set; }
       
      
        public string? ReasonBan { get; set; }
    }
}
