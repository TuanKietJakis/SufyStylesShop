using BussinessObject.Model;
using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class UserCommentLikeRepository : IUserCommentLikeRepository
    {
        private readonly SufyStylesShopContext _context;
        private readonly DbSet<PostCommentLike> _dbSet;

        public UserCommentLikeRepository(SufyStylesShopContext context)
        {
            _context = context;
            _dbSet = context.Set<PostCommentLike>();
        }

      
        public async Task<PostCommentLike?> GetById(params Guid?[]? id)
        {
            if (id == null || id.Length == 0)
            {
                throw new ArgumentException("At least one ID is required.");
            }
            return await _dbSet.FindAsync(id.Cast<object>().ToArray());
        }

        public void Add(PostCommentLike entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(PostCommentLike entity)
        {
            _dbSet.Update(entity);
        }

      
        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
