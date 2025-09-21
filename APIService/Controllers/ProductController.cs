using APIService.Extension;
using APIService.Service;
using BussinessObject.DTO.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;
        private readonly ProductFeedbackService _feedbackService;

        public ProductController(ProductService productService, ProductFeedbackService feedbackService)
        {
            _productService = productService;
            _feedbackService = feedbackService;
        }

        [HttpGet("GetAllProducts")]
        public ActionResult<List<ProductDto>> GetAllProducts()
        {
            try
            {
                var products = _productService.GetAllProducts();
                return Ok(products);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    Message = "An error occurred while retrieving products.",
                    Error = ex.Message
                });
            }
        }

        [HttpGet("ProductVendor/GetAll")]
        public async Task<IActionResult> GetAllProductVendors()
        {
            try
            {
                var productVendors = await _productService.GetAllProductVendors();

                return Ok(productVendors);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }
        [HttpGet("SearchProductByName")]
        public ActionResult<List<ProductDto>> SearchProducts([FromQuery] string searchTerm)
        {
            try
            {
                var productDtos = _productService.SearchProducts(searchTerm);

                if (productDtos == null || productDtos.Count == 0)
                {
                    return NotFound("Not found");
                }

                return Ok(productDtos);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while searching for products.", Error = ex.Message });
            }
        }

        [HttpGet("GetProductDetail/{productId}")]
        public async Task<ActionResult<ProductDetailDTO>> GetProductDetail(Guid productId)
        {
            try
            {
                var productDetail = await _productService.GetProductDetail(productId);

                if (productDetail == null)
                {
                    return NotFound("Not found product");
                }

                return Ok(productDetail);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while retrieving product details.", Error = ex.Message });
            }
        }

        [HttpGet("GetWishlistByUser/{userId}")]
        public async Task<IActionResult> GetWishListProducts(Guid userId)
        {
            try
            {
                var products = await _productService.GetWishList(userId);

                if (products == null || !products.Any())
                {
                    return NotFound("Not Found in WishList.");
                }

                return Ok(products);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while retrieving the wishlist.", Error = ex.Message });
            }
        }


        [HttpPost("CreateWishlist")]
        public async Task<IActionResult> CreateWishList([FromQuery] Guid userId, [FromQuery] Guid productId)
        {
            try
            {
                var result = await _productService.CreateWishList(userId, productId);

                if (!result)
                {
                    return BadRequest("The product already exists in the WishList with an active state.");
                }

                return Ok("The product has been added or updated successfully in the WishList.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpDelete("RemoveWishlist")]
        public async Task<IActionResult> RemoveWishList([FromQuery] Guid userId, [FromQuery] Guid productId)
        {
            try
            {
                var result = await _productService.RemoveWishList(userId, productId);

                if (!result)
                {
                    return BadRequest("The product was not found in the WishList or it has already been deleted.");
                }

                return Ok("The product has been successfully removed from the WishList.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }


        [HttpPost("Feedback/Create")]
        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> CreateFeedback([FromBody] CreateFeedback model)
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
                var result = await _feedbackService.CreateFeedback(
                    model.ProductId,
                    curentUserId,
                    model.Content,
                    model.Rating
                );

                if (result)
                {
                    return Ok(new { Message = "Feedback created successfully." });
                }

                return StatusCode(500, "An error occurred while creating feedback.");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpPut("Feedback/Update/{feedbackId}")]
        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> UpdateFeedback(Guid feedbackId, [FromBody] UpdateFeedback model)
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
                var result = await _feedbackService.UpdateFeedbackUser(
                    feedbackId,
                    model.Content,
                    model.Rating,
                    curentUserId
                    
                );

                if (result)
                {
                    return Ok(new { Message = "Feedback updated successfully." });
                }

                return StatusCode(500, "An error occurred while updating feedback.");
            }
            catch (ArgumentException ex)
            {
                return NotFound(new { Message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpGet("Feedback/Get/{productId}")]
        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> GetFeedback(Guid productId)
        {
            try
            {
                var curentUserId = JwtHelper.GetUserIdFromClaims(User);
                var feedbackDto = await _feedbackService.GetFeedbackByProductAndUser(productId, curentUserId);

                if (feedbackDto == null)
                {
                    return NotFound(new { Message = "No feedback found for this product and user." });
                }

                return Ok(feedbackDto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while retrieving feedback.", Error = ex.Message });
            }
        }

        [HttpGet("Feedback/GetByUser")]
        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> GetFeedbackByUser()
        {
            try
            {
                var curentUserId = JwtHelper.GetUserIdFromClaims(User);
                var feedbackDto = await _feedbackService.GetFeedbackByUser(curentUserId);

                if (feedbackDto == null)
                {
                    return NotFound(new { Message = "No feedback found for this user." });
                }

                return Ok(feedbackDto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while retrieving feedback.", Error = ex.Message });
            }
        }



    }
}
