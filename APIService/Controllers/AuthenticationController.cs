using APIService.Extension;
using APIService.Service;
using BussinessObject.DTO.Authentication;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly AuthenService _authService;

        public AuthenticationController(AuthenService authService)
        {
            _authService = authService;
        }

     
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest model)
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
                var result = await _authService.Login(model.Email, model.Password);
                if (result == null)
                {
                    return Unauthorized(new { Message = "Invalid email or password." });
                }

                // Trả về token, role và userId
                return Ok(new
                {
                    Token = result.Token,
                    Id = result.Id,
                    Role = result.Role,
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }

        [HttpPost("google-login")]
        public async Task<IActionResult> GoogleLogin([FromBody] GoogleLoginRequest model)
        {
            try
            {
                var result = await _authService.GoogleLogin(model.Email, model.UrlImage);
                return Ok(new
                {
                    Token = result.Token,
                    Id = result.Id,
                    Role = result.Role,
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }


    }

}

