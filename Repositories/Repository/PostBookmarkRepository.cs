using BussinessObject.DTO;
using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class PostBookmarkRepository : IPostBookmarkRepository
    {
        private readonly SufyStylesShopContext _context;
        private readonly DbSet<PostBookmark> _dbSet;

        public PostBookmarkRepository(SufyStylesShopContext context)
        {
            _context = context;
            _dbSet = context.Set<PostBookmark>();
        }

        public IQueryable<PostBookmark> GetAll()
        {
            return _dbSet.AsQueryable();
        }

        public IQueryable<PostBookmark> GetAllByUserId(Guid userId)
        {
            return _dbSet
                .Include(pbm => pbm.Post)
                .Where(pbm => pbm.UserId == userId);
        }

        public async Task<PostBookmark?> GetById(params Guid?[]? id)
        {
            if (id == null || id.Length == 0)
            {
                throw new ArgumentException("At least one ID is required.");
            }
            return await _dbSet.FindAsync(id.Cast<object>().ToArray());
        }

        public void Add(PostBookmark entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(PostBookmark entity)
        {
            _dbSet.Update(entity);
        }

    
        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }

    }
}