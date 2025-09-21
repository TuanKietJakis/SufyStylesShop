using APIService.Extension;
using APIService.Service;
using BussinessObject.DTO.Cart;
using BussinessObject.DTO.Product;
using Microsoft.AspNetCore.Mvc;

namespace APIService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly CartService _cartService;

        public CartController(CartService cartService)
        {
            _cartService = cartService;
        }

        [HttpGet("GetCart")]
        public async Task<IActionResult> GetCartItems()
        {
            try
            {
                var curentUserId = JwtHelper.GetUserIdFromClaims(User);
                var cartItems = await _cartService.GetCartItemsByUserId(curentUserId);

                return Ok(cartItems);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while retrieving cart items.", Error = ex.Message });
            }
        }


        [HttpPost("AddCart")]
        public async Task<IActionResult> AddToCart([FromBody] AddToCart request)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();
                return BadRequest(new { errors });
            }
            try
            {
                var curentUserId = JwtHelper.GetUserIdFromClaims(User);
            
                var result = await _cartService.AddProductToCart(curentUserId, request.ProductId, request.VariantId, request.Quantity);
                
                if (result)
                {
                    return Ok("Product added to cart successfully.");
                }
                return BadRequest("Failed to add product to cart.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }

        [HttpPut("UpdateCart")]
        public async Task<IActionResult> UpdateCartItem([FromBody] UpdateCartItem request)
        {
            try
            {
                var curentUserId = JwtHelper.GetUserIdFromClaims(User);
             
                var result = await _cartService.UpdateProductInCart(curentUserId, request.CartItemId, request.VariantId, request.Quantity);
                if (result)
                {
                    return Ok("Cart item updated successfully.");
                }
                return BadRequest("Failed to update cart item.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }


        [HttpDelete("DeleteCart")]
        public async Task<IActionResult> DeleteProductFromCart(Guid cartItemId)
        {
            try
            {
                var curentUserId = JwtHelper.GetUserIdFromClaims(User);
                var result = await _cartService.DeleteProductFromCart(curentUserId, cartItemId);
                if (result)
                {
                    return Ok(new { message = "Product removed from cart successfully." });
                }
                return BadRequest(new { message = "Failed to remove product from cart." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpGet("GetProductVariants/{productId}")]
        public async Task<ActionResult<ProductDetailDTO>> GetProductVariant(Guid productId)
        {
            try
            {
                var productDetail = await _cartService.GetProductVariant(productId);

                if (productDetail == null)
                {
                    return NotFound("Not found product");
                }

                return Ok(productDetail);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while retrieving product variants.", Error = ex.Message });
            }
        }


    }
}
