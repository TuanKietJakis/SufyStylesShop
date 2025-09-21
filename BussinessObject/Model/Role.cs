using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BussinessObject.Models;

public class Role
{
    [Key]
    public Guid RoleId { get; set; } = Guid.NewGuid();
    [Required]
    [StringLength(20)]
    public string? RoleName { get; set; }

    public bool IsDeleted { get; set; } = false;
    
}
//Thực tế trong ứng dụng: Hầu hết các tên vai trò thông dụng không vượt quá 20 ký tự. Chúng thường ngắn gọn và dễ hiểu, ví dụ như "Super Admin" (12 ký tự), "System Administrator" (19 ký tự), "Content Manager" (15 ký tự), v.v.