using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.DTO.InfoPage
{
    public class CreateBannerDto
    {
        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "UrlImage is required.")]
        [MaxLength(150, ErrorMessage = "UrlImage cannot exceed 150 characters.")]
        public string UrlImage { get; set; }

        [Required(ErrorMessage = "Position is required.")]
        [MaxLength(10, ErrorMessage = "Position cannot exceed 10 characters.")]
        public string Position { get; set; }

        public bool? IsVisible { get; set; }
    }

}
