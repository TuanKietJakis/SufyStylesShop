using System.ComponentModel.DataAnnotations;

namespace BussinessObject.DTO.InfoPage
{
    public class CreateContactFormDto
    {
        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        [MaxLength(255, ErrorMessage = "Email cannot exceed 255 characters.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Subject is required.")]
        [MaxLength(255, ErrorMessage = "Subject cannot exceed 255 characters.")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Message is required.")]
        [MaxLength(1000, ErrorMessage = "Message cannot exceed 1000 characters.")]
        public string Message { get; set; }
    }
}
