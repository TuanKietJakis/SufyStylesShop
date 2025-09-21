using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.Services.Mail
{
    public class OtpInfo
    {
        public string Otp { get; set; }
        public DateTime Expiration { get; set; }
    }
}
