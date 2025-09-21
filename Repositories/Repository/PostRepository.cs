using BussinessObject.DTO;
using BussinessObject.Models;
using BussinessObject.Utils;
using Microsoft.EntityFrameworkCore;
using Repositories.IRepository;
using System.Linq.Expressions;

namespace Repositories.Repository
{
    public class PostRepository : IPostRepository
    {
        private readonly SufyStylesShopContext _context;
        private readonly DbSet<Post> _dbSet;

        public PostRepository(SufyStylesShopContext context)
        {
            _context = context;
            _dbSet = context.Set<Post>();
        }

        public IQueryable<Post> GetAll()
        {
            return _dbSet
                .Include(p => p.Author)
                    .ThenInclude(p => p.Following)
                .Include(p => p.PostLikes)
                    .ThenInclude(pl => pl.User)
                        .ThenInclude(u => u.Following)
                .Include(p => p.PostComments)
                    .ThenInclude(c => c.User)
                        .ThenInclude(u => u.Following)
                .Include(p => p.PostImages)
                .Include(p => p.PostProductTags);
        }

        public async Task<Post?> GetById(params Guid?[]? id)
        {
            if (id == null || id.Length == 0)
                throw new ArgumentException("At least one ID is required.");

            return await _dbSet
                .Include(p => p.Author)
                    .ThenInclude(p => p.Following)
                .Include(p => p.PostLikes)
                    .ThenInclude(pl => pl.User)
                        .ThenInclude(u => u.Following)
                .Include(p => p.PostComments)
                    .ThenInclude(c => c.User)
                        .ThenInclude(u => u.Following)
                .Include(p => p.PostImages)
                .Include(p => p.PostProductTags)
                .FirstOrDefaultAsync(p => p.PostId == id[0]);
        }

        public void Add(Post entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(Post entity)
        {
            _dbSet.Update(entity);
        }

        public void SoftDelete(Guid id)
        {
            var entity = _dbSet.Find(id);
            if (entity == null)
                throw new Exception("Entity not found.");

            entity.IsDeleted = true;
            _dbSet.Update(entity);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }

        public void AddImage(PostImage image)
        {
            _context.Entry(image).State = EntityState.Added;
        }

        public IQueryable<Post> GetAllByUserId(Guid userId)
        {
            return GetAll().Where(p => p.AuthorId == userId);
        }

        
        public async Task<List<Product>> GetProductsByIds(List<Guid> productIds)
        {
            return await _context.Products
                .Where(p => productIds.Contains(p.ProductId))
                .ToListAsync();
        }

        public async Task<Post?> GetPostByUserIdAndPostId(Guid userId, Guid postId)
        {
            return await GetAll().FirstOrDefaultAsync(p => p.PostId == postId && p.AuthorId == userId);
        }

        
    }
}
