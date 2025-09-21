using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.DTO.Post
{
    public class PostAdminDto
    {
        public Guid PostId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Content { get; set; }
        public string? PageTitle { get; set; }
        public string? MetaDescription { get; set; }
        public string? UrlVideo { get; set; }
        public string? UrlHandle { get; set; }
        public bool? IsVisible { get; set; }
        public bool? IsDeleted { get; set; }
        public bool IsReported { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? ViewNumber { get; set; }
        public PostUserStaffDto? Author { get; set; }
        public int NumberLike { get; set; } = 0;
        public int NumberComment { get; set; } = 0;
        public List<PostImageDto> PostImages { get; set; } = new List<PostImageDto>();
        public List<PostProductTagDto> PostProductTags { get; set; } = new List<PostProductTagDto>();
    }
    public class PostAdminDetailDto
    {
        public Guid PostId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Content { get; set; }
        public string? PageTitle { get; set; }
        public string? MetaDescription { get; set; }
        public string? UrlVideo { get; set; }
        public string? UrlHandle { get; set; }
        public bool? IsVisible { get; set; }
        public bool? IsDeleted { get; set; }
        public bool IsReported { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? ViewNumber { get; set; }
        public PostUserStaffDto? Author { get; set; }
        public List<PostLikeAdminDto> PostLikes { get; set; } = new List<PostLikeAdminDto>();
        public List<PostCommentAdminDto> PostComments { get; set; } = new List<PostCommentAdminDto>();
        public List<PostImageDto> PostImages { get; set; } = new List<PostImageDto>();
        public List<PostProductTagDto> PostProductTags { get; set; } = new List<PostProductTagDto>();
    }
    public class PostCommentAdminDto
    {
        public Guid PostCommentId { get; set; }
        public Guid PostId { get; set; }
        public Guid UserId { get; set; }
        public string ProfileName { get; set; } = string.Empty;
        public string? UrlImage { get; set; }
        public string? Content { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        public long LikeNumber { get; set; } = 0;

    }

    public class PostUserStaffDto
    {
        public Guid UserId { get; set; }
        public string ProfileName { get; set; } = string.Empty;
        public string? UrlImage { get; set; }

    }
}
