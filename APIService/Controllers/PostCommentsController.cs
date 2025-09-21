using APIService.Extension;
using APIService.Service;
using BussinessObject.DTO;
using BussinessObject.DTO.Comment;
using BussinessObject.DTO.Post;
using BussinessObject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;

namespace APIService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PostCommentsController : ControllerBase
    {
        private readonly PostCommentService _postCommentService;

        public PostCommentsController(PostCommentService postCommentService)
        {
            _postCommentService = postCommentService;
        }

       
        [HttpGet("GetComment/{commentId}")]
        public async Task<IActionResult> GetCommentById(Guid commentId)
        {
            try
            {
                var commentDto = await _postCommentService.GetCommentById(commentId);
                return Ok(commentDto);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost("Create/{postId}")]
        public async Task<IActionResult> CreateComment(Guid postId,[FromBody] CommentCreateDto createCommentDto)
        {
            try
            {
                var userId = JwtHelper.GetUserIdFromClaims(User);
                await _postCommentService.CreateComment(userId, postId,createCommentDto);
                return Ok(new { message = "Comment added successfully" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }


        [HttpPut("Update/{commentId}")]
        public async Task<IActionResult> UpdateComment(Guid commentId, [FromBody] CommentUpdateDto updateCommentDto)
        {
            try
            {
                var userId = JwtHelper.GetUserIdFromClaims(User);
                await _postCommentService.UpdateComment(commentId,userId, updateCommentDto);

                return Ok(new { message = "Update comment succcess" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }

        
        [HttpDelete("Delete/{commentId}")]
        public async Task<IActionResult> DeleteComment(Guid commentId)
        {
            try
            {
                var userId = JwtHelper.GetUserIdFromClaims(User);
                await _postCommentService.DeleteComment(userId,commentId);
                return Ok(new { message = "Delete comment succcess" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }


        [HttpPost("Like/{commentId}")]
        public async Task<IActionResult> LikeComment(Guid commentId)
        {
            try
            {
                var curentUserId = JwtHelper.GetUserIdFromClaims(User);
                await _postCommentService.LikeComment(commentId, curentUserId);
                return Ok(new { message = "Comment liked successfully!" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        
        [HttpPost("Unlike/{commentId}")]
        public async Task<IActionResult> RemoveLikeComment(Guid commentId)
        {
            try
            {
                var curentUserId = JwtHelper.GetUserIdFromClaims(User);
                await _postCommentService.RemoveLikeComment(commentId, curentUserId);
                return Ok(new { message = "Like removed successfully!" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
