using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.DTO.User
{
    public class AddressDto
    {
        public Guid AddressId { get; set; }
        public Guid UserId { get; set; }
        public string Fullname { get; set; }
        public string Phone { get; set; }
        public string AddressName { get; set; }
        public bool IsDeleted { get; set; }

    }
    public class AddressCreateEditDto
    {
        [Required(ErrorMessage = "Fullname is required.")]
        [StringLength(50, ErrorMessage = "Fullname cannot exceed 50 characters.")]
        public string Fullname { get; set; }


        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression(@"^0\d{9}$", ErrorMessage = "Phone number must start with 0 and have exactly 10 digits.")]
        public string Phone { get; set; }



        [Required(ErrorMessage = "Address is required.")]
        [StringLength(255, ErrorMessage = "Address cannot exceed 255 characters.")]
        public string AddressName { get; set; }
    }
}
