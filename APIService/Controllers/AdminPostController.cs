using APIService.Extension;
using APIService.Service;
using BussinessObject.DTO.Admin;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AuthorizeRole("Admin")]
    public class AdminPostController : ControllerBase
    {
      
        private readonly PostService _postService;

        public AdminPostController(PostService postService)
        {
           
            _postService = postService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllPosts()
        {
            try
            {
                var posts = await _postService.GetAllPostAdmin();
                return Ok(posts);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
        [HttpGet("GetDetail/{postId}")]
        public async Task<IActionResult> GetPostDetailById(Guid postId)
        {
            try
            {
                var postDetail = await _postService.GetPostAdminDetailById(postId);
                if (postDetail == null)
                    return NotFound(new { message = "Post not found" });
                return Ok(postDetail);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

      

        [HttpPost("Post/ChangeIsVisible/{postId}")]
        public async Task<IActionResult> ChangeIsVisible(Guid postId, ApprovePost approvePost)
        {
            try
            {
                var curentUserId = JwtHelper.GetUserIdFromClaims(User);
                await _postService.ChangeIsVisible(postId, approvePost);
                return Ok(new { message = "Change success" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpDelete("DeletePost/{postId}")]
        public async Task<IActionResult> DeletePost(Guid postId)
        {
            try
            {        
                await _postService.DeletePostAdmin(postId);
                return Ok(new { message = "Delete post succcess" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
