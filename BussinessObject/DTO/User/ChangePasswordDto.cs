using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.DTO.User
{
    public class ChangePasswordDto : IValidatableObject
    {
        [Required]
        public Guid Id { get; set; }


        [Required(ErrorMessage = "Old Password is required.")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[!@#$%^&*()_+\\-={}\\[\\]:;\\'\\\"<>,.?/]).{8,15}$",
            ErrorMessage = "Old Password must be 8-15 characters long and include numbers, lowercase letters, uppercase letters, and special characters (!@#$%^&*).")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "New Password is required.")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[!@#$%^&*()_+\\-={}\\[\\]:;\\'\\\"<>,.?/]).{8,15}$",
         ErrorMessage = "New Password must be 8-15 characters long and include numbers, lowercase letters, uppercase letters, and special characters (!@#$%^&*).")]
        public string NewPassword { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (OldPassword == NewPassword)
            {
                yield return new ValidationResult("New password cannot be the same as the old password.", new[] { nameof(NewPassword) });
            }
        }
    }
}
