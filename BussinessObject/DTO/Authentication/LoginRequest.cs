using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.DTO.Authentication
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        [StringLength(50, ErrorMessage = "Email must be max 50 characters")]
        public string Email { get; set; } = null!;
 
        [Required(ErrorMessage = "Password is required.")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[!@#$%^&*()_+\\-={}\\[\\]:;\\'\\\"<>,.?/]).{8,15}$",
            ErrorMessage = "Password must be 8-15 characters long and include numbers, lowercase letters, uppercase letters, and special characters (!@#$%^&*).")]
        public string Password { get; set; } = null!;
    }
}
