using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.IRepository;

public class PostLikeRepository : IPostLikeRepository
{
    private readonly SufyStylesShopContext _context;
    private readonly DbSet<PostLike> _dbSet;

    public PostLikeRepository(SufyStylesShopContext context)
    {
        _context = context;
        _dbSet = context.Set<PostLike>();
    }

    public async Task<PostLike?> GetById(params Guid?[]? id)
    {
        if (id == null || id.Length == 0)
        {
            throw new ArgumentException("At least one ID is required.");
        }
        return await _dbSet.FindAsync(id.Cast<object>().ToArray());
    }
    public void Add(PostLike entity)
    {
        _dbSet.Add(entity);
    }

    public void Update(PostLike entity)
    {
        _dbSet.Update(entity);
    }

    public async Task SaveChanges()
    {
        await _context.SaveChangesAsync();
    }
}