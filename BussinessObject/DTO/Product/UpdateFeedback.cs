using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.DTO.Product
{
    public class UpdateFeedback
    {    
        [StringLength(500, ErrorMessage = "Content length cannot exceed 500 characters.")]
        public string Content { get; set; }

        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        public int Rating { get; set; }
    }
    public class UpdateFeedbackAdmin
    {    
        [StringLength(500, ErrorMessage = "Content length cannot exceed 500 characters.")]
        public string Content { get; set; }

        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        public int Rating { get; set; }

        public bool IsFinished { get; set; }
    }
}
