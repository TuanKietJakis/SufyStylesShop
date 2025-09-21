using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BussinessObject.Models;

public class PostBookmark
{
    public Guid UserId { get; set; }
    public Guid PostId { get; set; }
    public DateTime SaveDate { get; set; } = DateTime.Now;
    public bool IsDeleted { get; set; } = false;
    public virtual Post? Post { get; set; }
    public virtual User? User { get; set; }
}
