using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace BussinessObject.Models
{
    public class OrderedDetail
    {
        [Key]
        public Guid OrderedProductId { get; set; } = Guid.NewGuid();

        [Required]
        public Guid ProductId { get; set; }

        [Required]
        public Guid VariantId { get; set; }

        [Required]
        public Guid OrderId { get; set; }

        [Required] 
        [StringLength(100)] 
        public string ProductName { get; set; } = string.Empty;

        [Range(1, int.MaxValue)] 
        public int? Quantity { get; set; }

        [Column(TypeName = "decimal(18,2)")] 
        public double? ProductPrice { get; set; }
        public virtual Product? Product { get; set; }

        public virtual Order? Order { get; set; }  
        public virtual ProductVariant? ProductVariant { get; set; }   
    }
}
