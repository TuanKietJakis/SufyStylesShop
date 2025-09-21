using BussinessObject.DTO.Cart;
using BussinessObject.DTO.Product;
using BussinessObject.Models;
using ISUZU_NEXT.Server.Core.Extentions;
using Repositories.IRepository;
using Repository.IRepository;

namespace APIService.Service
{
    public class CartService
    {
        private readonly ICartRepository _cartRepository;
        private readonly IProductRepository _productRepository;  
        private readonly IUserRepository _userRepository;

        public CartService(ICartRepository cartRepository, IProductRepository productRepository, IUserRepository userRepository)
        {
            _cartRepository = cartRepository;
            _productRepository = productRepository;
            _userRepository = userRepository;
        }

        public async Task<List<CartItemDto>> GetCartItemsByUserId(Guid userId)
        {

            var cartItems = await _cartRepository.GetListCartItemsByUserId(userId);

            var cartItemDtos = cartItems.Select(cartItem =>
            {
                var cartItemDto = new CartItemDto();
                cartItemDto.CopyProperties(cartItem);
                cartItemDto.ProductName = cartItem.Product?.ProductName;
                cartItemDto.ProductVendorName = cartItem.Product?.ProductVendor?.ProductVendorName;
                cartItemDto.SalePricePercent = cartItem.Product?.SalePricePercent;
                cartItemDto.ProductUrl = cartItem.Product?.ProductUrl;
              
                
                if (cartItem.Product?.ProductVariants != null && cartItem.VariantId != Guid.Empty)
                {
                    var selectedVariant = cartItem.Product.ProductVariants
                        .FirstOrDefault(v => v.VariantId == cartItem.VariantId);

                    if (selectedVariant != null)
                    {
                        cartItemDto.Option1 = selectedVariant.Option1;
                        cartItemDto.OptionValue1 = selectedVariant.OptionValue1;
                        cartItemDto.Option2 = selectedVariant.Option2;
                        cartItemDto.OptionValue2 = selectedVariant.OptionValue2;
                        cartItemDto.Option3 = selectedVariant.Option3;
                        cartItemDto.OptionValue3 = selectedVariant.OptionValue3;
                        cartItemDto.Price = selectedVariant.Price;
                        cartItemDto.MaxQuantity = selectedVariant.Quantity;
                        cartItemDto.UrlImage = selectedVariant.UrlImage;
                    }
                }

                cartItemDto.Quantity = cartItem.Quantity;

                return cartItemDto;
            }).ToList();

            return cartItemDtos;
        }
        private async Task ValidateUser(Guid userId)
        {
            var user = await _userRepository.GetUserById(userId);
            if (user == null)
                throw new ArgumentException("User not found.");
        }

        private async Task<(Product product, ProductVariant variant, long availableQuantity)> ValidateProductAndStock(Guid productId, Guid variantId)
        {
            var product = await _productRepository.GetProductByProductId(productId);
            if (product == null || product.IsDeleted)
                throw new ArgumentException("Product not found or is deleted.");

            ProductVariant? variant = null;
            long availableQuantity;

           
           variant = product.ProductVariants.FirstOrDefault(v => v.VariantId == variantId);
           if (variant == null || variant.Quantity <= 0)
                    throw new ArgumentException("Selected product variant is unavailable or out of stock.");
           availableQuantity = variant.Quantity;
           

            return (product, variant, availableQuantity);
        }

    
        private async Task<CartItem> GetCartItemAndValidateOwnership(Guid userId, Guid cartItemId)
        {
            var cartItem = await _cartRepository.GetCartItemById(cartItemId);
            if (cartItem == null)
                throw new ArgumentException("Cart item not found.");
            if (cartItem.IsDeleted)
                throw new ArgumentException("Cart item is deleted. Please add it again to your cart.");
            if (cartItem.UserId != userId)
                throw new UnauthorizedAccessException("You are not authorized to modify this cart item.");
            return cartItem;
        }

        public async Task<bool> AddProductToCart(Guid userId, Guid productId, Guid variantId, int quantity)
        {
            await ValidateUser(userId);

            var (product, _, availableQuantity) = await ValidateProductAndStock(productId, variantId);

            if (quantity > availableQuantity)
                throw new ArgumentException($"Cannot add to cart. Available stock: {availableQuantity}, requested: {quantity}");

            var cartItem = await _cartRepository.GetCartItemByUserIdAndProduct(userId, productId, variantId);

            if (cartItem == null)
            {
                cartItem = new CartItem
                {
                    UserId = userId,
                    ProductId = productId,
                    VariantId = variantId,
                    Quantity = quantity,
                    IsDeleted = false
                };
                await _cartRepository.Add(cartItem);
            }
            else
            {
                cartItem.Quantity = cartItem.IsDeleted ? quantity : cartItem.Quantity + quantity;
                cartItem.IsDeleted = false;

                if (cartItem.Quantity > availableQuantity)
                    throw new ArgumentException($"Cannot add to cart. Available stock: {availableQuantity}, requested: {cartItem.Quantity}");

                await _cartRepository.Update(cartItem);
            }

            return true;
        }


        public async Task<bool> UpdateProductInCart(Guid userId, Guid cartItemId, Guid variantId, int quantity)
        {
            var cartItem = await GetCartItemAndValidateOwnership(userId, cartItemId);

            var (product, variant, availableQuantity) = cartItem.VariantId != variantId
                ? await ValidateProductAndStock(cartItem.ProductId, variantId)
                : await ValidateProductAndStock(cartItem.ProductId, cartItem.VariantId);

            if (quantity > availableQuantity)
                throw new ArgumentException($"Quantity exceeds available stock. Available: {availableQuantity}");

            cartItem.VariantId = variantId;
            cartItem.Quantity = quantity;

            await _cartRepository.Update(cartItem);
         
            return true;
        }


        public async Task<bool> DeleteProductFromCart(Guid userId, Guid cartItemId)
        {
            var cartItem = await _cartRepository.GetCartItemById(cartItemId);
            if (cartItem == null || cartItem.IsDeleted || cartItem.UserId != userId)
            {
                throw new ArgumentException("Cart item not found or is already deleted or not authorized.");
            }

            cartItem.IsDeleted = true;
            await _cartRepository.Update(cartItem);
            return true; 
        }

        public async Task<ProductUpdateCart> GetProductVariant(Guid productId)
        {
            var product = await _productRepository.GetProductByProductId(productId);

            if (product == null)
            {
                return null;
            }

            var productDetailDto = new ProductUpdateCart();

            productDetailDto.CopyProperties(product);
            
            productDetailDto.UrlImage = product.UrlImage;
          
            return productDetailDto;
        }

    }
}
