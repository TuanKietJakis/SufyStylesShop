using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.DTO.Product;

namespace BussinessObject.DTO.Order
{
    public class OrderDTO
    {
        public Guid OrderId { get; set; }
        public Guid UserId { get; set; }
        public Guid PaymentMethodId { get; set; }
        public string Address { get; set; }
        public Guid? ComfirmUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? PaymentStatus { get; set; }
        public string Fullname { get; set; }
        public int? OrderStatus { get; set; }
        public double? OrderShippingFee { get; set; }
        public double? SubTotal { get; set; }
        public DateTime? CancelDate { get; set; }
        public double? OrderTotalPrice { get; set; }
        public DateTime? ComfirmDate { get; set; }
        public string? Phone { get; set; }
        public string? ReasonCancel { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public List<OrderedDetailDTO> OrderDetails { get; set; } = new List<OrderedDetailDTO>();
    }

    public class OrderedDetailDTO 
    {
        public Guid OrderedProductId { get; set; }
        public Guid ProductId { get; set; }
        public Guid VariantId { get; set; }
        public Guid OrderId { get; set; }
        public string ProductName { get; set; }
        public int? Quantity { get; set; }
        public double? ProductPrice { get; set; }
        public virtual ProductVariantDTO? ProductVariant { get; set; }
    }

    public class ProductVariantDTO
    {
        public Guid VariantId { get; set; }
        public Guid ProductId { get; set; }
        public double? Price { get; set; }
        public long Quantity { get; set; }
        public string UrlImage { get; set; }
        public string? Option1 { get; set; }
        public string? Option2 { get; set; }
        public string? Option3 { get; set; }
        public string? OptionValue1 { get; set; }
        public string? OptionValue2 { get; set; }
        public string? OptionValue3 { get; set; }
        public bool IsDeleted { get; set; }
       
    }

    public class PaymentMethodDto
    {     
        public Guid PaymentMethodId { get; set; } = Guid.NewGuid();

        public string PaymentName { get; set; } = string.Empty;

        public bool IsDeleted { get; set; } = false;

    }

}
