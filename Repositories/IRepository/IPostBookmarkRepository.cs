using BussinessObject.DTO;
using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepository
{
    public interface IPostBookmarkRepository
    {
        IQueryable<PostBookmark> GetAll();
        IQueryable<PostBookmark> GetAllByUserId(Guid userId);
        Task<PostBookmark?> GetById(params Guid?[]? id);
        void Add(PostBookmark entity);
        void Update(PostBookmark entity);

        Task SaveChanges();
       
    }
}
