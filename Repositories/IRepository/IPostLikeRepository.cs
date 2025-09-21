using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepository
{
    public interface IPostLikeRepository
    {
        Task<PostLike?> GetById(params Guid?[]? id);
        void Add(PostLike entity);
        void Update(PostLike entity);
      
        Task SaveChanges();
    }
}
