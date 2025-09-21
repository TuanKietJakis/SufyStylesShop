
using BussinessObject.DTO.Product;
using BussinessObject.Models;
using ISUZU_NEXT.Server.Core.Extentions;
using Microsoft.EntityFrameworkCore;
using Repositories.IRepository;
using Repository.IRepository;

namespace APIService.Service
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;
       
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        
        }

        public List<ProductDto> GetAllProducts()
        {
            var products = _productRepository.GetAllProduct();

            var productDtos = products.Select(product =>
            {
                var productDto = new ProductDto();
                productDto.CopyProperties(product);

                productDto.ProductVendorName = product.ProductVendor?.ProductVendorName;
                productDto.ProductVendorUrlImage = product.ProductVendor?.UrlImage;

                productDto.Price = product.ProductVariants
                    .Where(v => v.Price.HasValue)  
                    .Min(v => v.Price) ?? 0;

                return productDto;
            }).ToList();

            return productDtos;
        }  
        public List<ProductStaffDto> GetAllProductsStaff()
        {
            var products = _productRepository.GetAllProductStaff();

            var productDtos = products.Select(product =>
            {
                var productDto = new ProductStaffDto();
                productDto.CopyProperties(product);

                productDto.ProductVendorName = product.ProductVendor?.ProductVendorName;
                productDto.ProductVendorUrlImage = product.ProductVendor?.UrlImage;
               
                return productDto;
            }).ToList();

            return productDtos;
        }
        public List<ProductDto> SearchProducts(string searchTerm)
        {
            var products = _productRepository.GetAllProduct()
                    .Where(p => p.ProductName.ToLower().Contains(searchTerm.ToLower())
                      )
                     .ToList();
            if (products.Count == 0) return null;
            var productDtos = products.Select(product =>
            {
                var productDto = new ProductDto();
                productDto.CopyProperties(product);

                productDto.ProductVendorName = product.ProductVendor?.ProductVendorName;
           
                return productDto;
            }).ToList();

            return productDtos;
        }

        public async Task<ProductDetailDTO> GetProductDetail(Guid productId)
        {
            var product = await _productRepository.GetProductByProductId(productId);

            if (product == null)
            {
                return null;
            }

            var productDetailDto = new ProductDetailDTO();

            productDetailDto.CopyProperties(product);
            productDetailDto.ProductVendorName = product.ProductVendor?.ProductVendorName;

            productDetailDto.ProductFeedbacks = product.ProductFeedbacks
                .Select(c => new ProductFeedbackDTO
                {
                    FeedbackId = c.ProductFeedbackId,
                    UserId = c.UserId,
                    Content = c.Content,
                    Rating = c.Rating,
                    CreatedDate = c.CreatedDate,
                    UserFullName = c.User.ProfileName
                }).ToList();

         
            return productDetailDto;
        }
         public async Task<ProductDetailStaffDTO> GetProductStaffDetail(Guid productId)
        {
            var product = await _productRepository.GetProductByProductId(productId);

            if (product == null)
            {
                return null;
            }

            var productDetailDto = new ProductDetailStaffDTO();

            productDetailDto.CopyProperties(product);
            productDetailDto.ProductVendorName = product.ProductVendor?.ProductVendorName;
    
            return productDetailDto;
        }

        public async Task<List<ProductDto>> GetWishList(Guid userId)
        {
            var wishLists = await _productRepository.GetWishListsByUserId(userId);

            return wishLists.Select(w =>
            {
                var productDto = new ProductDto();
                productDto.CopyProperties(w.Product);
                productDto.ProductVendorName = w.Product.ProductVendor?.ProductVendorName;

                return productDto;
            }).ToList();
        }

        public async Task<bool> CreateWishList(Guid userId, Guid productId)
        {
            var existingWishList = await _productRepository.GetWishList(userId, productId);

            if (existingWishList != null)
            {
                if (existingWishList.IsDeleted)
                {
                    existingWishList.IsDeleted = false;
                    existingWishList.SaveDate = DateTime.UtcNow;
                    return await _productRepository.UpdateWishList(existingWishList);
                }
                return false;
            }

            var newWishList = new UserWishList
            {
                UserId = userId,
                ProductId = productId,
                SaveDate = DateTime.UtcNow,
                IsDeleted = false
            };

            return await _productRepository.CreateWishList(newWishList);
        }


        public async Task<bool> RemoveWishList(Guid userId, Guid productId)
        {
            var wishList = await _productRepository.GetWishList(userId, productId);

            if (wishList == null || wishList.IsDeleted)
            {
                return false;
            }

            wishList.IsDeleted = true;
            return await _productRepository.UpdateWishList(wishList);
        }


        public async Task<Guid> CreateProduct(CreateProductRequest request, Guid userId)
        {
          
            var product = new Product();
            product.CopyProperties(request);
            product.CreateDate = DateTime.UtcNow;

            product.UserId = userId;

            await _productRepository.AddProduct(product);

           
            return product.ProductId;
        }

        public async Task<bool> UpdateProduct(UpdateProductRequest request)
        {
            var product = await _productRepository.GetProductDetail(request.ProductId);
            if (product == null)
            {
                return false;
            }

            // Only update properties that are not null in the request
            if (request.ProductName != null) product.ProductName = request.ProductName;
            if (request.Description != null) product.Description = request.Description;
            if (request.PageTitle != null) product.PageTitle = request.PageTitle;
            if (request.MetaDescription != null) product.MetaDescription = request.MetaDescription;
            if (request.ProductTypeName != null) product.ProductTypeName = request.ProductTypeName;
            if (request.ProductVendorId.HasValue) product.ProductVendorId = request.ProductVendorId.Value;
            if (request.ProductUrl != null) product.ProductUrl = request.ProductUrl;
            if (request.IsVisible.HasValue) product.IsVisible = request.IsVisible.Value;
            if (request.SalePricePercent.HasValue) product.SalePricePercent = request.SalePricePercent.Value;
            if (request.UrlImage != null) product.UrlImage = request.UrlImage;
            if (request.AltText != null) product.AltText = request.AltText;
            if (request.IsFeatured.HasValue) product.IsFeatured = request.IsFeatured.Value;

            product.UpdateDate = DateTime.UtcNow;
            await _productRepository.UpdateProduct(product);

            if (request.ProductVariants == null || !request.ProductVariants.Any())
            {
                return true;
            }

            // Handle variants
            var existingVariants = product.ProductVariants.ToList();
            var newVariants = new List<ProductVariant>();

            foreach (var variantRequest in request.ProductVariants)
            {
                if (variantRequest.VariantId.HasValue)
                {
                    // Update existing variant
                    var existingVariant = existingVariants.FirstOrDefault(v => v.VariantId == variantRequest.VariantId);
                    if (existingVariant != null)
                    {
                        // Only update properties that are not null in the request
                        if (variantRequest.Price.HasValue) existingVariant.Price = variantRequest.Price.Value;
                        if (variantRequest.Quantity.HasValue) existingVariant.Quantity = variantRequest.Quantity.Value;
                        if (variantRequest.UrlImage != null) existingVariant.UrlImage = variantRequest.UrlImage;
                        if (variantRequest.Option1 != null) existingVariant.Option1 = variantRequest.Option1;
                        if (variantRequest.Option2 != null) existingVariant.Option2 = variantRequest.Option2;
                        if (variantRequest.Option3 != null) existingVariant.Option3 = variantRequest.Option3;
                        if (variantRequest.OptionValue1 != null) existingVariant.OptionValue1 = variantRequest.OptionValue1;
                        if (variantRequest.OptionValue2 != null) existingVariant.OptionValue2 = variantRequest.OptionValue2;
                        if (variantRequest.OptionValue3 != null) existingVariant.OptionValue3 = variantRequest.OptionValue3;
                    }
                }
                else
                {
                    // Create new variant
                    var newVariant = new ProductVariant
                    {
                        ProductId = product.ProductId,
                        Price = variantRequest.Price ?? 0,
                        Quantity = variantRequest.Quantity ?? 0,
                        UrlImage = variantRequest.UrlImage,
                        Option1 = variantRequest.Option1,
                        Option2 = variantRequest.Option2,
                        Option3 = variantRequest.Option3,
                        OptionValue1 = variantRequest.OptionValue1,
                        OptionValue2 = variantRequest.OptionValue2,
                        OptionValue3 = variantRequest.OptionValue3
                    };
                     newVariants.Add(newVariant);
                }
            }

            // Save new variants if any
            if (newVariants.Any())
            {
                await _productRepository.AddProductVariants(newVariants);
            }
            await _productRepository.SaveChanges();
            return true;
        }


        public async Task<bool> DeleteProduct(Guid productId)
        {
            var product = await _productRepository.GetProductById(productId);

            if (product == null)
            {
                return false; 
            }

            product.IsDeleted = true;
            product.IsVisible = false;
            await _productRepository.UpdateProduct(product);

            return true; 
        }

        public async Task<bool> CreateProductVendor(CreateProductVendorDto productVendorDto)
        {
            var newProductVendor = new ProductVendor
            {
                ProductVendorName = productVendorDto.ProductVendorName,
                UrlImage = productVendorDto.UrlImage,
                SaveDate = DateTime.UtcNow,
                IsDeleted = false
            };

            try
            {
                await _productRepository.AddProductVendor(newProductVendor);
                return true; 
            }
            catch
            {
                return false; 
            }
        }


        public async Task<bool> UpdateProductVendor(Guid productVendorId, UpdateProductVendorDto productVendorDto)
        {
            var productVendor = await _productRepository.GetProductVendorById(productVendorId);

            if (productVendor == null)
            {
                return false;
            }

            productVendor.CopyProperties(productVendorDto);
            productVendor.SaveDate = DateTime.UtcNow;

            await _productRepository.UpdateProductVendor(productVendor);

            return true;
        }

        public async Task<List<ProductVendorDto>> GetAllProductVendors()
        {
            var productVendors = await _productRepository.GetAllProductVendors();

            return productVendors.Select(pv => new ProductVendorDto
            {
                ProductVendorId = pv.ProductVendorId,
                ProductVendorName = pv.ProductVendorName,
                UrlImage = pv.UrlImage,
                IsDeleted = pv.IsDeleted
            }).ToList();
        }

        public async Task<bool> DeleteProductVendor(Guid productVendorId)
        {
 
            var productVendor = await _productRepository.GetProductVendorById(productVendorId);

            if (productVendor == null)
            {
                return false;
            }

            productVendor.IsDeleted = true;

            await _productRepository.UpdateProductVendor(productVendor);

            return true;
        }

    }
}
