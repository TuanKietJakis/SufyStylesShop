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
    public class PostCommentRepository : IPostCommentRepository
    {
        private readonly SufyStylesShopContext _context;
        private readonly DbSet<PostComment> _dbSet;

        public PostCommentRepository(SufyStylesShopContext context)
        {
            _context = context;
            _dbSet = context.Set<PostComment>();
        }

     
        public IQueryable<PostComment> GetAllByUserId(Guid userId)
        {
            return _dbSet.Where(p => p.UserId == userId);
        }

        public async Task<PostComment?> GetById(params Guid?[]? id)
        {
            if (id == null || id.Length == 0)
            {
                throw new ArgumentException("At least one ID is required.");
            }

            return await _dbSet
                .Include(c => c.User)
                .Include(c => c.PostCommentLikes)
                    .ThenInclude(like => like.User)
                .FirstOrDefaultAsync(c => c.PostCommentId == id[0]);
        }

        public void Add(PostComment entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(PostComment entity)
        {
            _dbSet.Update(entity);
        }

        public void SoftDelete(Guid id)
        {
            var entity = _dbSet.Find(id);
            if (entity == null)
            {
                throw new Exception("Entity not found.");
            }

            var isDeletedProperty = typeof(PostComment).GetProperty("IsDeleted");
            if (isDeletedProperty != null)
            {
                isDeletedProperty.SetValue(entity, true);
                _dbSet.Update(entity);
            }
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
