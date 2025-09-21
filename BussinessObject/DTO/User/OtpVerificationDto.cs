using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.DTO.User
{
    public class EmailRequest
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address!\r\nA valid email address is one that has not been previously registered in the system, follows the correct format (e.g., example@gmail.com), and does not exceed 50 characters in length. ")]
        [StringLength(50, ErrorMessage = "Invalid Email Address!\r\nA valid email address is one that has not been previously registered in the system, follows the correct format (e.g., example@gmail.com), and does not exceed 50 characters in length. ")]
        public string Mail { get; set; } = string.Empty;
    }
    public class OtpVerificationDto
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address!\r\nA valid email address is one that has not been previously registered in the system, follows the correct format (e.g., example@gmail.com), and does not exceed 50 characters in length. ")]
        [StringLength(50, ErrorMessage = "Invalid Email Address!\r\nA valid email address is one that has not been previously registered in the system, follows the correct format (e.g., example@gmail.com), and does not exceed 50 characters in length. ")]
        public string Email { get; set; }
        [Required(ErrorMessage = "OTP is required.")]
        [RegularExpression(@"^\d{6}$", ErrorMessage = "OTP must be exactly 6 digits.")]
        public string Otp { get; set; }

    }

    public class PhoneNumberRequest
    {
        [Required(ErrorMessage = "Phone number is required.")]
        [StringLength(15, ErrorMessage = "Phone number must not exceed 15 characters.")]
        public string PhoneNumber { get; set; } = string.Empty;
    }

}
