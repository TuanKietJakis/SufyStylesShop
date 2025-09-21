using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.DTO.User
{
    public class UserDtoWithEmailPass
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address!\r\nA valid email address is one that has not been previously registered in the system, follows the correct format (e.g., example@gmail.com), and does not exceed 50 characters in length.\"")]
        [StringLength(50, ErrorMessage = "Invalid Email Address!\r\nA valid email address is one that has not been previously registered in the system, follows the correct format (e.g., example@gmail.com), and does not exceed 50 characters in length.\"")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[!@#$%^&*()_+\\-={}\\[\\]:;\\'\\\"<>,.?/]).{8,15}$",
            ErrorMessage = "Password must be 8-15 characters long and include numbers, lowercase letters, uppercase letters, and special characters (!@#$%^&*).")]
        public string Password { get; set; }
    }
}
