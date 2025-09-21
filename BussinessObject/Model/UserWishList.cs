using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BussinessObject.Models;

public class UserWishList
{

    [Required]
    public Guid UserId { get; set; }
    [Required]
    public Guid ProductId { get; set; }

    public DateTime? SaveDate { get; set; }
    public bool IsDeleted { get; set; } = false;

    public virtual Product Product { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
