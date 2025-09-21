
using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.DTO.Post
{
    public class PostProductTagDto
    {
        public Guid PostProductTagId { get; set; }
        public Guid PostId { get; set; }
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string UrlImage { get; set; }
    }
}
