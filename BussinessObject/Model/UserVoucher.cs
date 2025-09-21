using BussinessObject.Models;
using System.ComponentModel.DataAnnotations;
using BussinessObject.DTO.UserVoucher;


namespace BussinessObject.Model
{
    public class UserVoucher
    {
        public void UpdateStatus(bool isActive)
        {
            IsActive = isActive;
        }
        public void Update(UserVoucherUpdateDto dto)
        {
            if (dto.DiscountValue.HasValue)
            {
                DiscountValue = dto.DiscountValue.Value;
            }

            if (dto.MinimumOrderValue.HasValue)
            {
                MinimumOrderValue = dto.MinimumOrderValue.Value;
            }
            if(dto.DiscountValue > dto.MinimumOrderValue)
            {
                throw new ArgumentException("Discount Value cannot be greater than the Minimum Order Value.");
            }

            if (dto.ExpiryDate.HasValue)
            {
                ExpiryDate = dto.ExpiryDate.Value;
            }

            if (dto.StartDate.HasValue)
            {
                if (dto.StartDate.Value > dto.ExpiryDate.Value)
                {
                    throw new ArgumentException("Start Date cannot be earlier than Expiry Date.");
                }

                StartDate = dto.StartDate.Value;
              
            }

            if (dto.MaxUsage.HasValue)
            {
                MaxUsage = dto.MaxUsage.Value;
            }

            if (!string.IsNullOrEmpty(dto.Description))
            {
                Description = dto.Description;
            }
            IsActive = dto.IsActive;

        }
        public static UserVoucher Create(UserVoucherCreateDto dto)
        {
            if (!dto.DiscountValue.HasValue || dto.DiscountValue.Value <= 0)
            {
                throw new ArgumentException("Discount Value must be a positive number.");
            }

            if (!dto.MinimumOrderValue.HasValue || dto.MinimumOrderValue.Value <= 0)
            {
                throw new ArgumentException("Minimum Order Value must be a positive number.");
            }
            if (dto.DiscountValue > dto.MinimumOrderValue)
            {
                throw new ArgumentException("Discount Value cannot be greater than the Minimum Order Value.");
            }
            if (!dto.StartDate.HasValue)
            {
                throw new ArgumentException("Start Date is required.");
            }

            if (!dto.ExpiryDate.HasValue)
            {
                throw new ArgumentException("Expiry Date is required.");
            }
        
            if (!dto.MaxUsage.HasValue || dto.MaxUsage.Value <= 0)
            {
                throw new ArgumentException("Max Usage must be a positive number.");
            }

            if (dto.StartDate.Value > dto.ExpiryDate.Value)
            {
                throw new ArgumentException("Start Date cannot be earlier than Expiry Date.");
            }

            var userVoucher = new UserVoucher
            {
                UserCreateId = dto.UserId,
                DiscountValue = dto.DiscountValue.Value,
                MinimumOrderValue = dto.MinimumOrderValue.Value,
                ExpiryDate = dto.ExpiryDate.Value,
                StartDate = dto.StartDate.Value,
                IsActive = dto.IsActive,           
                MaxUsage = dto.MaxUsage.Value,
                CurrentUsage = 0,
                Description = dto.Description,
                CreateDate = DateTime.UtcNow,
                
            };
            return userVoucher;
        }
        [Key]
        public Guid VoucherId { get; set; } = Guid.NewGuid();
        [Required]
        public Guid UserCreateId { get; set; }
        [Required]
        public int DiscountValue { get; set; }
        [Required]
        public int MinimumOrderValue { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public bool IsActive { get; set; } = true;
        [Required]
        public int CurrentUsage { get; set; } = 0;
        [Required]
        public int MaxUsage { get; set; }
        [StringLength(255)]
        [Required]
        public string? Description { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public virtual User User { get; set; } = null!;
        public virtual ICollection<VoucherCheck> VoucherChecks { get; set; } = new List<VoucherCheck>();
    }
}
