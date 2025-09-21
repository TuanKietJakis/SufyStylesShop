using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepository;

public interface IProductRepository 
{
    IEnumerable<Product> GetAllProductStaff();
    IEnumerable<Product> GetAllProduct();
    Task<Product> GetProductByProductId(Guid productId);
    Task<List<UserWishList>> GetWishListsByUserId(Guid userId);

    Task<UserWishList?> GetWishList(Guid userId, Guid productId);
    Task<bool> CreateWishList(UserWishList wishList);
    Task<bool> UpdateWishList(UserWishList wishList);

    Task AddProduct(Product product);
    
    Task AddProductVariants(IEnumerable<ProductVariant> productVariants);
    
    Task SaveChanges();
    Task<Product?> GetProductDetail(Guid productId);
    Task DeleteProductVariants(List<ProductVariant> variantsToDelete);
    Task AddOrUpdateProductVariants(IEnumerable<ProductVariant> productVariants);
    Task<Product> GetProductById(Guid productId);

    Task AddProductVendor(ProductVendor productVendor);
    Task<ProductVendor?> GetProductVendorById(Guid productVendorId);

    Task UpdateProductVendor(ProductVendor productVendor);

    Task<List<ProductVendor>> GetAllProductVendors();

    Task UpdateProduct(Product product);
}
