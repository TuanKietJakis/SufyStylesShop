using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.DTO.Authentication
{
    public class LoginResult
    {
        public string Token { get; set; }
        public string Role { get; set; }
        public string Id { get; set; }
    }

}
