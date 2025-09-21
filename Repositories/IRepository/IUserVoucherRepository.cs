using BussinessObject.DTO;
using BussinessObject.Model;
using BussinessObject.Models;
using BussinessObject.Utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repositories.IRepository
{
    public interface IUserVoucherRepository
    {
        IQueryable<UserVoucher> GetAll();
        Task<UserVoucher?> GetById(params Guid?[]? id);
        void Add(UserVoucher entity);
        void Update(UserVoucher entity);
       
        Task SaveChanges();
        Task<PaginatedResponse<UserVoucher>> GetPaginatedList(PaginationParams paginationParams);
        Task<PaginatedResponse<UserVoucher>> GetPaginatedListUser(Guid userId,PaginationParams paginationParams);

        Task<bool> CheckVoucherUsed(Guid userId, Guid voucherId);
        Task IncreaseCurrentUsage(Guid userId, Guid voucherId);
     


    }
}
