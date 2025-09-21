using BussinessObject.Model;
using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepository
{
    public interface IUserCommentLikeRepository
    {
    
        Task<PostCommentLike?> GetById(params Guid?[]? id);
        void Add(PostCommentLike entity);
        void Update(PostCommentLike entity);
        Task SaveChanges();
    }
}
