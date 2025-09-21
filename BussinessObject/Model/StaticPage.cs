using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace BussinessObject.Model
{
    public class StaticPage
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; } // (100 Bytes) Tên trang, ví dụ "About Us", "Privacy Policy".

        [Required]
        [MaxLength(4000)]
        public string Content { get; set; } // (4000 Bytes) Nội dung trang có thể dài, ví dụ chính sách, điều khoản sử dụng.

       /* Content: 4000 ký tự(hoặc dài hơn tùy yêu cầu thực tế)
Lý do: Nội dung trang có thể rất dài, ví dụ như mô tả chi tiết về các chính sách, giới thiệu công ty, hoặc các điều khoản sử dụng.Tham khảo từ các trang TMĐT như Amazon và eBay, nội dung các trang này có thể chứa nhiều văn bản.Tuy nhiên, bạn có thể cân nhắc tăng giới hạn nếu trang này có nội dung dài, ví dụ: "Privacy Policy" thường rất dài, khoảng 2000-4000 từ hoặc hơn.
Nguồn tham khảo: Các chính sách bảo mật của Amazon (thường từ 3000-4000 từ) và eBay có thể dài hơn.*/
        public DateTime UpdateDate { get; set; } = DateTime.Now;

        public Guid? UpdatedUserId { get; set; }

        [ForeignKey("UpdatedUserId")]
        [JsonIgnore]
        public virtual User? UpdatedByUser { get; set; }
    }

    public class FAQ
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Category { get; set; } // (255 Bytes) Danh mục câu hỏi.

        [Required]
        [MaxLength(500)]
        public string Question { get; set; } // (500 Bytes) Câu hỏi thường không dài hơn 500 ký tự.

        [Required]
        [MaxLength(2000)]
        public string Answer { get; set; } // (2000 Bytes) Câu trả lời chi tiết cho câu hỏi.
        // Nguồn tham khảo: Các trang FAQ của Amazon và eBay thường có câu trả lời dài, thậm chí lên tới 2000 ký tự.
        public DateTime UpdateDate { get; set; } = DateTime.Now;

        public bool? IsDeleted { get; set; }

        public Guid? UpdatedUserId { get; set; }

        [JsonIgnore]
        [ForeignKey("UpdatedUserId")]
        public virtual User? UpdatedByUser { get; set; }
    }

    public class ContactForm
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } // (255 Bytes) Tên người liên hệ.

        [Required]
        [EmailAddress]
        [MaxLength(255)]
        public string Email { get; set; } // (255 Bytes) Địa chỉ email, tối đa 255 ký tự. Lý do: Địa chỉ email có thể dài đến 255 ký tự (theo chuẩn RFC 5321), do đó giới hạn này là hợp lý.

        [Required]
        [MaxLength(255)]
        public string Subject { get; set; } // (255 Bytes) Tiêu đề email. Lý do: Tiêu đề email thông thường không vượt quá 255 ký tự, đủ để mô tả vấn đề một cách ngắn gọn.

        [Required]
        [MaxLength(1000)]
        public string Message { get; set; } // (1000 Bytes) Tin nhắn liên hệ. Lý do: Tin nhắn liên hệ có thể dài, nhưng thông thường không vượt quá 2000 ký tự. Nếu cần dài hơn, có thể mở rộng thêm.
    /*    Nguồn tham khảo: Các trang thương mại điện tử lớn, như Amazon và eBay, có các biểu mẫu liên hệ với giới hạn tin nhắn khoảng 1000-2000 ký tự.*/

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public bool IsFinished { get; set; } = false;
        public Guid? FinishUserId { get; set; }

        [JsonIgnore]
        [ForeignKey("UserId")]
        public virtual User? User { get; set; }
    }

    public class Banner
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } //  Tên banner quảng cáo.

        [Required]
        [MaxLength(150)]
        public string UrlImage { get; set; } // (2000 Bytes) URL của hình ảnh banner.

        public bool? IsVisible { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [MaxLength(10)]
        public string Position { get; set; }

        public Guid? UpdatedUserId { get; set; }

        [ForeignKey("UpdatedUserId")]
        [JsonIgnore]
        public virtual User? User { get; set; }
    }

}
