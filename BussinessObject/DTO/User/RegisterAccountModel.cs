using System;
using System.ComponentModel.DataAnnotations;

namespace BussinessObject.DTO.User
{
    public class RegisterAccountModel
    {
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(50, ErrorMessage = "Username cannot exceed 50 characters.")]
        public string? Username { get; set; }

        [StringLength(50, ErrorMessage = "Profile Name cannot exceed 50 characters.")]
        public string? ProfileName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address!\r\n A valid email address is one that has not been previously registered in the system, follows the correct format (e.g., example@gmail.com), and does not exceed 50 characters in length.")]
        [StringLength(50, ErrorMessage = "Invalid Email Address!\r\nA valid email address is one that has not been previously registered in the system, follows the correct format (e.g., example@gmail.com), and does not exceed 50 characters in length. ")]
        public string? Email { get; set; }


        [Required(ErrorMessage = "Phone number is required.")]
        [Phone(ErrorMessage = "Phone Number must start with 0 and have exactly 10 digits.")]
        [StringLength(10, ErrorMessage = "Phone Number must start with 0 and have exactly 10 digits.")]
        [MinLength(10, ErrorMessage = "Phone Number must start with 0 and have exactly 10 digits.")]
        [RegularExpression(@"^0\d{9}$", ErrorMessage = "Phone Number must start with 0 and have exactly 10 digits.")]
        public string Phone { get; set; }

        public bool? IsAcceptMarketing { get; set; } = false;

        [Required(ErrorMessage = "Password is required.")]
 
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[!@#$%^&*()_+\\-={}\\[\\]:;\\'\\\"<>,.?/]).{8,15}$",
            ErrorMessage = "Password must be 8-15 characters long and include numbers, lowercase letters, uppercase letters, and special characters (!@#$%^&*).")]
        public string? Password { get; set; }
    }
}
