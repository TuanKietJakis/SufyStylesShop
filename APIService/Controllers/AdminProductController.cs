using APIService.Service;
using BussinessObject.DTO.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminProductController : ControllerBase
    {
        private readonly ProductFeedbackService _feedbackService;

        public AdminProductController(ProductFeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }

        [HttpGet("Product/Feedback/GetAll")]
        public async Task<ActionResult<List<FeedbackDto>>> GetAllFeedbacks()
        {
            try
            {
                var feedbacks = await _feedbackService.GetAllFeedbacks();
                return Ok(feedbacks);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while retrieving feedbacks.", Error = ex.Message });
            }
        }



        [HttpPut("Product/Feedback/Update/{feedbackId}")]
        public async Task<IActionResult> UpdateFeedback(Guid feedbackId, [FromBody] UpdateFeedbackAdmin model)
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
                var result = await _feedbackService.UpdateFeedbackAdmin(
                    feedbackId,
                    model.Content,
                    model.Rating,
                    model.IsFinished
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
      
    }
}
