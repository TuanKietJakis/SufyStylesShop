using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.DTO.Product
{
    public class FeedbackDto
    {
        public Guid ProductFeedbackId { get; set; }
        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProfileName { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsReported { get; set; }

       
    }
}
