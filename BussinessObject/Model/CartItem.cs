using BussinessObject.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class CartItem
{
    [Key]
    public Guid CartItemId { get; set; } = Guid.NewGuid();

    [Required]
    public Guid UserId { get; set; }

    [Required]
    public Guid ProductId { get; set; }
    [Required]
    public Guid VariantId { get; set; }

    [Required]
    [Range(1, 10)]
    public long Quantity { get; set; }

    public bool IsDeleted { get; set; } = false;

    public virtual User User { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
    
}
