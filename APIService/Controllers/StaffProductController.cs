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
    [Authorize(Roles = "Staff,Admin")]
    public class StaffProductController : ControllerBase
    {
        private readonly ProductService _productService;

    

        public StaffProductController(ProductService productService)
        {
            _productService = productService;
          
        }

        [HttpGet("Product/GetAll")]
        public ActionResult<List<ProductStaffDto>> GetAllProducts()
        {
            try
            {
                var products = _productService.GetAllProductsStaff();
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
        [HttpGet("Product/GetProductDetail/{productId}")]
        public async Task<ActionResult<ProductDetailStaffDTO>> GetProductDetail(Guid productId)
        {
            try
            {
                if (productId == Guid.Empty)
                {
                    return BadRequest("Invalid product ID.");
                }

                var productDetail = await _productService.GetProductStaffDetail(productId);

                if (productDetail == null)
                {
                    return NotFound("Product not found.");
                }

                return Ok(productDetail);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while retrieving product details.", Error = ex.Message });
            }
        }


        [HttpPost("Product/Import")]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductRequest request)
        {
            try
            {
                var curentUserId = JwtHelper.GetUserIdFromClaims(User);
                var productId = await _productService.CreateProduct(request,curentUserId);
                return Ok(new { ProductId = productId, Message = "Product created successfully!" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }

        [HttpPut("Product/Update")]
        public async Task<IActionResult> UpdateProduct([FromBody] UpdateProductRequest request)
        {
            try
            {
                var isUpdated = await _productService.UpdateProduct(request);

                if (!isUpdated)
                {
                    return NotFound("Product not found.");
                }

                return Ok(new { Message = "Product updated successfully." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while updating the product.", Error = ex.Message });
            }
        }

        [HttpDelete("Product/Delete/{productId}")]
        public async Task<IActionResult> DeleteProduct(Guid productId)
        {
            try
            {
                var result = await _productService.DeleteProduct(productId);

                if (!result)
                {
                    return NotFound("Product not found.");
                }

                return Ok("Product deleted successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while deleting the product.", Error = ex.Message });
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

        [HttpPost("ProductVendor/Import")]
        public async Task<IActionResult> CreateProductVendor([FromBody] CreateProductVendorDto productVendorDto)
        {
            try
            {
                var success = await _productService.CreateProductVendor(productVendorDto);

                if (!success)
                {
                    return BadRequest(new { Message = "Failed to create product vendor." });
                }

                return Ok(new { Message = "The product vendor has been successfully created." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }


        [HttpPut("ProductVendor/Update/{productVendorId}")]
        public async Task<IActionResult> UpdateProductVendor(Guid productVendorId, [FromBody] UpdateProductVendorDto productVendorDto)
        {
            try
            {
                var result = await _productService.UpdateProductVendor(productVendorId, productVendorDto);

                if (!result)
                {
                    return NotFound(new { Message = "Product Vendor not found" });
                }
                return Ok(new { Message = "Product vendor updated successfully" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }

        [HttpDelete("ProductVendor/Delete/{productVendorId}")]
        public async Task<IActionResult> DeleteProductVendor(Guid productVendorId)
        {
            try
            {
                var result = await _productService.DeleteProductVendor(productVendorId);

                if (!result)
                {
                    return NotFound(new { Message = "ProductVendor not found or cannot be deleted" });
                }

                return Ok(new { Message = "ProductVendor successfully deleted." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }


      
    }
}
