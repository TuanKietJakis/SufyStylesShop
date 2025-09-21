using BussinessObject.DTO;
using BussinessObject.Model;
using BussinessObject.Models;
using BussinessObject.Utils;
using Microsoft.EntityFrameworkCore;
using Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class UserVoucherRepository : IUserVoucherRepository
    {
        private readonly SufyStylesShopContext _context;
        private readonly DbSet<UserVoucher> _dbSet;

        public UserVoucherRepository(SufyStylesShopContext context)
        {
            _context = context;
            _dbSet = context.Set<UserVoucher>();
        }

        public IQueryable<UserVoucher> GetAll()
        {
            return _dbSet.AsQueryable();
        }
      
        public IQueryable<UserVoucher> GetAll(Guid userId)
        {
            return _dbSet.Where(uv => !uv.VoucherChecks.Any(vc => vc.UserId == userId));
        }


        public async Task<UserVoucher?> GetById(params Guid?[]? id)
        {
            if (id == null || id.Length == 0)
            {
                throw new ArgumentException("At least one ID is required.");
            }
            return await _dbSet.FindAsync(id.Cast<object>().ToArray());
        }

        public void Add(UserVoucher entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(UserVoucher entity)
        {
            _dbSet.Update(entity);
        }

    
        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<bool> CheckVoucherUsed(Guid userId, Guid voucherId)
        {
            return await _context.VoucherChecks
                .AnyAsync(vc => vc.UserId == userId && vc.VoucherId == voucherId);
        }

        public async Task IncreaseCurrentUsage(Guid userId, Guid voucherId)
        {
            // Lấy user và role
            var user = await _context.Users
                .Include(u => u.Role)
                .FirstOrDefaultAsync(u => u.UserId == userId);

            if (user == null)
            {
                return;
            }

            // Tìm userVoucher theo userId và voucherId
            var userVoucher = await _context.UserVouchers
                .FirstOrDefaultAsync(uv => uv.VoucherId == voucherId);

            if (userVoucher == null)
            {
                return;
            }

            userVoucher.CurrentUsage += 1;

            var roleName = user.Role?.RoleName?.ToLower();
            if (roleName != "admin" && roleName != "staff")
            {
                var voucherCheck = new VoucherCheck
                {
                    VoucherId = voucherId,
                    UserId = userId,
                    UseDate = DateTime.Now,
                };

                _context.VoucherChecks.Add(voucherCheck);
            }

            await _context.SaveChangesAsync();
        }


        public async Task<PaginatedResponse<UserVoucher>> GetPaginatedList(PaginationParams paginationParams)
        {
            IQueryable<UserVoucher> query = GetAll();

            var isDeletedProperty = typeof(UserVoucher).GetProperty("IsDeleted");
            if (isDeletedProperty != null && paginationParams.IsDeleted.HasValue)
            {
                query = query.Where(p => EF.Property<bool>(p, "IsDeleted") == paginationParams.IsDeleted.Value);
            }

            query = Filter(query, paginationParams);
            query = Sort(query, paginationParams);

            var totalItems = await query.CountAsync();
            var items = await query
                .Skip((paginationParams.PageNumber - 1) * paginationParams.PageSize)
                .Take(paginationParams.PageSize)
                .ToListAsync();

            return new PaginatedResponse<UserVoucher>(paginationParams.PageNumber, paginationParams.PageSize, totalItems, items);
        }
        public async Task<PaginatedResponse<UserVoucher>> GetPaginatedListUser(Guid userId, PaginationParams paginationParams)
        {
            IQueryable<UserVoucher> query = GetAll(userId);

            var isDeletedProperty = typeof(UserVoucher).GetProperty("IsDeleted");
            if (isDeletedProperty != null && paginationParams.IsDeleted.HasValue)
            {
                query = query.Where(p => EF.Property<bool>(p, "IsDeleted") == paginationParams.IsDeleted.Value);
            }

            query = Filter(query, paginationParams);
            query = Sort(query, paginationParams);

            var totalItems = await query.CountAsync();
            var items = await query
                .Skip((paginationParams.PageNumber - 1) * paginationParams.PageSize)
                .Take(paginationParams.PageSize)
                .ToListAsync();

            return new PaginatedResponse<UserVoucher>(paginationParams.PageNumber, paginationParams.PageSize, totalItems, items);
        }

        private IQueryable<UserVoucher> Filter(IQueryable<UserVoucher> query, PaginationParams paginationParams)
        {
            if (paginationParams is UserVoucherPaginationParams.UserFilter userVoucherParams)
            {
                if (userVoucherParams.UserId.HasValue && userVoucherParams.IsUsed.HasValue)
                {
                    if (userVoucherParams.IsUsed.Value == false)
                    {
                        query = query.Where(voucher => !voucher.VoucherChecks.Any(vc => vc.UserId == userVoucherParams.UserId.Value));
                    }
                    if (userVoucherParams.IsUsed.Value == true)
                    {
                        query = query.Where(voucher => voucher.VoucherChecks.Any(vc => vc.UserId == userVoucherParams.UserId.Value));
                    }
                }
                if (userVoucherParams.IsActive.HasValue)
                {
                    query = query.Where(voucher => voucher.IsActive == userVoucherParams.IsActive.Value);
                }
                if (userVoucherParams.IsAvailable.HasValue)
                {
                    if (userVoucherParams.IsAvailable.Value)
                    {
                        query = query.Where(voucher => voucher.CurrentUsage < voucher.MaxUsage || voucher.ExpiryDate > DateTime.Now);
                    }
                    else
                    {
                        query = query.Where(voucher => voucher.ExpiryDate <= DateTime.Now);
                    }
                }
            }
            return query;
        }

        private IQueryable<UserVoucher> Sort(IQueryable<UserVoucher> query, PaginationParams paginationParams)
        {
            return query;
        }
    }
}
