using APIService.Extension;
using APIService.Service;
using BussinessObject.DTO;
using BussinessObject.DTO.Post;
using BussinessObject.DTO.User;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace APIService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly PostService _postService;
        public PostsController(PostService postService)
        {
            _postService = postService;
        }
     
        [HttpGet("GetAllPosts")]
        public async Task<IActionResult> GetAllPost()
        {
            try
            {
                var curentUserId = JwtHelper.GetUserIdFromClaims(User);
                var paginatedResponse = await _postService.GetAll(curentUserId);
                return Ok(paginatedResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }


        [HttpGet("GetAllPostByUserId/{userId}")]
        public async Task<IActionResult> GetAllPostByUserId(Guid userId)
        {
            try
            {
                var curentUserId = JwtHelper.GetUserIdFromClaims(User);
                var paginatedResponse = await _postService.GetAllByUserId(curentUserId, userId);
                return Ok(paginatedResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
   
        [HttpGet("GetPostDetail/{postId}")]
        public async Task<IActionResult> GetPostById(Guid postId)
        {
            try
            {
                var curentUserId = JwtHelper.GetUserIdFromClaims(User);
                var post = await _postService.GetPostById(postId, curentUserId);
                return Ok(post);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
      
        [AuthorizeRole("Customer")]
        [HttpPost("CreatePost")]
        public async Task<IActionResult> CreatePost([FromBody] PostCreateDto postCreateDto)
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
                var post = await _postService.CreatePost(postCreateDto);
                return CreatedAtAction(nameof(GetPostById), new { postId = post.PostId }, post);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPut("UpdatePost/{postId}")]

        public async Task<IActionResult> UpdatePost(Guid postId, [FromBody] PostUpdateDto postUpdateDto)
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
                var userId = JwtHelper.GetUserIdFromClaims(User);
                await _postService.UpdatePost(postId, postUpdateDto,userId);
                return Ok(new { message = "Update post succcess" });
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
                var userId = JwtHelper.GetUserIdFromClaims(User);
                await _postService.DeletePost(postId, userId);
                return Ok(new { message = "Delete post succcess" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

      
        [HttpPost("{postId}/bookmark")]
        public async Task<IActionResult> BookmarkPost(Guid postId)
        {
            try
            {
                var userId = JwtHelper.GetUserIdFromClaims(User);
                await _postService.AddBookmark(postId, userId);
                return Ok(new { message = "Post added to save list successfully" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost("{postId}/unbookmark")]
        public async Task<IActionResult> UnbookmarkPost(Guid postId)
        {
            try
            {
                var userId = JwtHelper.GetUserIdFromClaims(User);
                await _postService.Unbookmark(postId, userId);
                return Ok(new { message = "Post removed from save list successfully" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });

            }
        }

        [HttpPost("{postId}/like")]
        public async Task<IActionResult> AddLike(Guid postId)
        {
            try
            {
                var userId = JwtHelper.GetUserIdFromClaims(User);
                await _postService.AddLike(postId, userId);
                return Ok(new { message = "Like added successfully" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
        [HttpPost("{postId}/unlike")]
        public async Task<IActionResult> UnLike(Guid postId)
        {
            try
            {
                var userId = JwtHelper.GetUserIdFromClaims(User);
                await _postService.RemoveLike(postId, userId);
                return Ok(new { message = "UnLike successfully" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpGet("GetAllNoLogin")]
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
    }
}
