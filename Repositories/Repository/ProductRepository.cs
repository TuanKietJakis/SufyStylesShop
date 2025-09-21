using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository;

public class ProductRepository : IProductRepository
{
    private readonly SufyStylesShopContext _context;
    public ProductRepository(SufyStylesShopContext context) 
    {
        _context = context;
    }
    public IEnumerable<Product> GetAllProduct()
    {
        return _context.Products
            .Include(p => p.ProductVendor)
                .Include(p => p.ProductVariants)
            .ToList();
    }
    public IEnumerable<Product> GetAllProductStaff()
    {
        return _context.Products
            .Include(p => p.ProductVendor) 
             .Include(p => p.ProductVariants)
            .ToList();
    }
  
    public async Task<Product> GetProductByProductId(Guid productId)
    {
        var product = await _context.Products
            .Include(p => p.ProductVendor)
            .Include(p => p.ProductVariants) 
            .Include(p => p.ProductFeedbacks.Where(pc => !pc.IsDeleted))
                .ThenInclude(pc => pc.User) 
            .Where(p => p.ProductId == productId)
            .FirstOrDefaultAsync();

        return product;
    }

    public async Task<List<UserWishList>> GetWishListsByUserId(Guid userId)
    {
        return await _context.UserWishLists
            .Where(w => w.UserId == userId && !w.IsDeleted && !w.Product.IsDeleted)
            .Include(w => w.Product) 
            .Include(w => w.Product.ProductVendor) 
            .ToListAsync();
    }

    public async Task<UserWishList?> GetWishList(Guid userId, Guid productId)
    {
        return await _context.Set<UserWishList>()
            .FirstOrDefaultAsync(w => w.UserId == userId && w.ProductId == productId);
    }

    public async Task<bool> CreateWishList(UserWishList wishList)
    {
        await _context.Set<UserWishList>().AddAsync(wishList);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> UpdateWishList(UserWishList wishList)
    {
        _context.Set<UserWishList>().Update(wishList);
        return await _context.SaveChangesAsync() > 0;
    }


    public async Task AddProduct(Product product)
    {
        await _context.Products.AddAsync(product);
        await _context.SaveChangesAsync();
    }

    public async Task AddProductVariants(IEnumerable<ProductVariant> productVariants)
    {
        await _context.ProductVariants.AddRangeAsync(productVariants);
        await _context.SaveChangesAsync();
    }
   

    public async Task SaveChanges()
    {
        await _context.SaveChangesAsync();
    }

    public async Task<Product?> GetProductDetail(Guid productId)
    {
        return await _context.Products  
            .Include(p => p.ProductVariants)   
            .FirstOrDefaultAsync(p => p.ProductId == productId);
    }


    public async Task DeleteProductVariants(List<ProductVariant> variantsToDelete)
    {
        _context.ProductVariants.RemoveRange(variantsToDelete);
        await _context.SaveChangesAsync();
    }
    public async Task AddOrUpdateProductVariants(IEnumerable<ProductVariant> productVariants)
    {
        foreach (var variant in productVariants)
        {
            var existingVariant = await _context.ProductVariants.FindAsync(variant.VariantId);
            if (existingVariant != null)
            {
                _context.Entry(existingVariant).CurrentValues.SetValues(variant);
            }
            else
            {
                await _context.ProductVariants.AddAsync(variant);
            }
        }
        await _context.SaveChangesAsync();
    }


    public async Task<Product> GetProductById(Guid productId)
    {
        return await _context.Products
                             .Where(p => p.ProductId == productId) 
                             .FirstOrDefaultAsync(); 
    }

    public async Task AddProductVendor(ProductVendor productVendor)
    {
        _context.ProductVendors.Add(productVendor);
        await _context.SaveChangesAsync();
    }

    public async Task<ProductVendor?> GetProductVendorById(Guid productVendorId)
    {
        return await _context.ProductVendors
            .FirstOrDefaultAsync(pv => pv.ProductVendorId == productVendorId && !pv.IsDeleted);
    }

    public async Task UpdateProductVendor(ProductVendor productVendor)
    {
        _context.ProductVendors.Update(productVendor);
        await _context.SaveChangesAsync();
    }

    public async Task<List<ProductVendor>> GetAllProductVendors()
    {
        return await _context.ProductVendors
                             .ToListAsync();
    }

    public async Task UpdateProduct(Product product)
    {
        _context.Products.Update(product);
        await _context.SaveChangesAsync();
    }



}
