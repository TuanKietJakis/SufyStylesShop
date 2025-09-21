using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepository
{
    public interface IPostCommentRepository
    {    
        IQueryable<PostComment> GetAllByUserId(Guid userId);
        Task<PostComment?> GetById(params Guid?[]? id);
        void Add(PostComment entity);
        void Update(PostComment entity);
        void SoftDelete(Guid id);
        Task SaveChanges();
    }
}
