using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.Model;

public class PostProductTag
{
    public Guid PostProductTagId { get; set; } = Guid.NewGuid();
    public Guid PostId { get; set; }
    
    public Guid ProductId { get; set; } = Guid.NewGuid();
    [StringLength(100)]
    public string ProductName { get; set; } = string.Empty;
    [StringLength(150)]
    public string UrlImage { get; set; }
    public virtual Post? Post { get; set; }
    public virtual Product? Product { get; set; }
}
