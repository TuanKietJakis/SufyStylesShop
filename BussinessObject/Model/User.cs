using BussinessObject.Model;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BussinessObject.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid UserId { get; set; }

        [Required]
        public Guid RoleId { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        public string? ProfileName { get; set; }
        // 50 ký tự đủ dài để chứa tên độc đáo nhưng không quá dài gây bất tiện.

        // Username: 50 ký tự
       //  Email: 100 ký tự ==> tham khảo facebook
        [Required]
        [EmailAddress]
        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(128)]
        public string? Password { get; set; }

        [StringLength(150)]
        public string UrlImage { get; set; } = "https://i.ibb.co/chpHF6x/No-Image-User.png";

        [StringLength(500)]
        public string? Bio { get; set; }

        [Phone]
        [StringLength(10)]
        public string? Phone { get; set; }

        [StringLength(50)]
        public string? Lastname { get; set; }

        [StringLength(50)]
        public string? Firstname { get; set; }

        // Christopher Alexander James Johnson
        public DateOnly? Birthday { get; set; }

        public bool? Gender { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool? IsAcceptMarketing { get; set; } = false;

        public bool IsDeleted { get; set; } = false;

        public bool IsBanned { get; set; } = false;

        [StringLength(255)]
        public string? ReasonBan { get; set; } = null;

        public virtual Role Role { get; set; } = null!;
        public virtual ICollection<UserFollow> Followers { get; set; } = new List<UserFollow>();
        public virtual ICollection<UserFollow> Following { get; set; } = new List<UserFollow>();
        public virtual ICollection<Order> Orders { get; set; } = null!;
        public virtual ICollection<UserAddress> Addresses { get; set; } = null!;
        public virtual ICollection<CartItem>? CartItems { get; set; } = new List<CartItem>();
        public virtual ICollection<UserWishList>? WishLists { get; set; } = new List<UserWishList>();

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
        // POST RELATION
        public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
        public virtual ICollection<PostLike> PostLikes { get; set; } = new List<PostLike>();
        public virtual ICollection<PostComment> PostComments { get; set; } = new List<PostComment>();
        public virtual ICollection<PostCommentLike> PostCommentLikes { get; set; } = new List<PostCommentLike>();
        public virtual ICollection<PostBookmark>? PostUserSaves { get; set; } = new List<PostBookmark>();

        public virtual ICollection<Order> ConfirmOrders { get; set; } = new List<Order>();

        public virtual ICollection<ContactForm> ContactForms { get; set; } = new List<ContactForm>();
        public virtual ICollection<StaticPage> CreatedStaticPages { get; set; } = new List<StaticPage>();

        public virtual ICollection<FAQ> CreatedFAQs { get; set; } = new List<FAQ>();

        public virtual ICollection<Banner> Banners { get; set; } = new List<Banner>();
        public virtual ICollection<UserVoucher> UserVouchers { get; set; } = new List<UserVoucher>();
    }
}

/*
Email cá nhân: Thường có độ dài ngắn, ví dụ: john.doe @gmail.com(17 ký tự).

Email doanh nghiệp: Có thể dài hơn, ví dụ: firstname.lastname @companyname.com(30 - 40 ký tự).*/