using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BussinessObject.Models;

public class UserAddress
{
    [Key]
    public Guid AddressId { get; set; } = Guid.NewGuid();

    [Required]
    public Guid UserId { get; set; }

    [Required]
    [StringLength(50)]
    public string Fullname { get; set; }

    [Required]
    [Phone(ErrorMessage = "Invalid phone number format.")]
    [StringLength(10, ErrorMessage = "Phone number cannot exceed 10 characters.")]

    public string Phone { get; set; }
    /* Các nền tảng như Facebook, Google, và Twitter đều sử dụng giới hạn 15 ký tự cho trường số điện thoại, do đó bạn có thể tham khảo thực tế từ các nền tảng này.*/

    [Required(ErrorMessage = "Address is required.")]
    [StringLength(255, ErrorMessage = "Address cannot exceed 255 characters.")]
    public string AddressName { get; set; }
    // Trong nhiều hệ thống thương mại điện tử (ví dụ: Shopify, WooCommerce), các trường như địa chỉ người dùng thường được thiết lập với giới hạn 255 ký tự. Điều này giúp đảm bảo đủ không gian cho các địa chỉ dài, nhưng không bị dư thừa.

    public bool IsDeleted { get; set; } = false;
 
    public virtual User User { get; set; } = null!;
}
