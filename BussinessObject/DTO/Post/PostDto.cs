using BussinessObject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.DTO.Post
{
    public class PostDto
    {
        public Guid PostId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Content { get; set; }
        public string? PageTitle { get; set; }
        public string? MetaDescription { get; set; }
        public string? UrlHandle { get; set; }
        public bool? IsVisible { get; set; }
        public bool? IsDeleted { get; set; }
        public bool IsReported { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool CanLike { get; set; } = true;
        public int? ViewNumber { get; set; }
        public PostUserDto? Author { get; set; }
        
        public List<PostLikeDto> PostLikes { get; set; } = new List<PostLikeDto>();

        public List<PostCommentDto> PostComments { get; set; } = new List<PostCommentDto>();

        public List<PostImageDto> PostImages { get; set; } = new List<PostImageDto>();
       
    }
    public class PostDetailDto
    {
        public Guid PostId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Content { get; set; }
        public string? PageTitle { get; set; }
        public string? MetaDescription { get; set; }
        public string? UrlHandle { get; set; }
        public bool? IsVisible { get; set; }
        public bool? IsDeleted { get; set; }
        public bool IsReported { get; set; }
        public string? ReasonReport { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        
        public bool? CanLike { get; set; } = null;
        public int? ViewNumber { get; set; }
   
        public PostUserDto? Author { get; set; }
        
        public List<PostLikeDto> PostLikes { get; set; } = new List<PostLikeDto>();

        public List<PostCommentDto> PostComments { get; set; } = new List<PostCommentDto>();

        public List<PostImageDto> PostImages { get; set; } = new List<PostImageDto>();
        public List<PostProductTagDto> PostProductTags { get; set; } = new List<PostProductTagDto>();
    }

}
