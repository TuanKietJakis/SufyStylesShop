using BussinessObject.DTO;
using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repositories.IRepository
{
    public interface IPostRepository
    {
        Task<Post?> GetById(params Guid?[]? id);
        IQueryable<Post> GetAll();
        void Add(Post entity);
        void Update(Post entity);
        void SoftDelete(Guid id);
        Task SaveChanges();

        IQueryable<Post> GetAllByUserId(Guid userId);
   
        Task<List<Product>> GetProductsByIds(List<Guid> productIds);
        Task<Post?> GetPostByUserIdAndPostId(Guid userId, Guid postId);

        void AddImage(PostImage image);
    }
}