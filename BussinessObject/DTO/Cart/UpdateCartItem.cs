using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.DTO.Cart
{
    public class UpdateCartItem
    {
        [Required]
        public Guid CartItemId { get; set; }
        [Required]
        public Guid VariantId { get; set; }

        [Required]
        [Range(1, 10, ErrorMessage = "Quantity must be greater than 0 and less than or equal to 10.")]
        public int Quantity { get; set; }

    }
}
