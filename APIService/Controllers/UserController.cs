using APIService.Extension;
using APIService.Service;
using BussinessObject.DTO;
using BussinessObject.DTO.User;
using BussinessObject.Model;
using BussinessObject.Models;
using ISUZU_NEXT.Server.Core.Extentions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Text.RegularExpressions;


namespace APIService.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;
        private readonly PostService _postService;
        private readonly EmailService _emailService;
      
        public UserController(UserService userService, EmailService emailService, PostService postService)
        {
            _userService = userService;
            _emailService = emailService;
            _postService = postService;
           
        }


        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterAccountModel registerData)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Values
                        .SelectMany(v => v.Errors)
                        .Select(e => e.ErrorMessage)
                        .ToList();
                    return BadRequest(new { errors });
                }

                var success = await _userService.Register(registerData);

                if (!success)
                {
                    return BadRequest(new { message = "The phone number already exists in the system." });
                }

                return Ok(new { message = "User account has been successfully created." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Server is busy, please try again later." });
            }
        }

        [HttpPost("sendOTP")]
        public async Task<IActionResult> SendOTP([FromQuery] EmailRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var firstError = ModelState.Values
                        .SelectMany(v => v.Errors)
                        .FirstOrDefault()?.ErrorMessage;

                    return BadRequest(new { error = firstError });
                }

                var checkMail = await _userService.CheckMail(request.Mail);
                if (!checkMail)
                {
                    return BadRequest(new { error = "User with this email does not exist." });
                }

             
                await _emailService.SendOtpMailForgetPass(request.Mail);

                return Ok(new { message = "OTP sent successfully" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }

        [HttpPost("sendRegisterOTP")]
        public async Task<IActionResult> SendRegisterOTP([FromQuery] EmailRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var firstError = ModelState.Values
                        .SelectMany(v => v.Errors)
                        .FirstOrDefault()?.ErrorMessage;

                    return BadRequest(new { error = firstError });
                }

                var checkMail = await _userService.CheckMail(request.Mail);
                if (checkMail)
                {
                    return BadRequest(new { error = "User with this email already exists." });
                }

                
                await _emailService.SendOtpMailRegister(request.Mail);

                return Ok(new { message = "OTP sent successfully" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while sending OTP.", error = ex.Message });
            }
        }


        [HttpPost("verifyOTP")]
        public async Task<IActionResult> VerifyOtp([FromBody] OtpVerificationDto otpVerificationDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Values
                        .SelectMany(v => v.Errors)
                        .Select(e => e.ErrorMessage)
                        .ToList();
                    return BadRequest(new { errors });
                }

                var result = await _emailService.VerifyOtp(otpVerificationDto.Email, otpVerificationDto.Otp);

                if (string.Equals(result, "OTP verified.", StringComparison.OrdinalIgnoreCase))
                {
                    return Ok(new { message = result });
                }

                return BadRequest(new { message = result });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while verifying OTP.", error = ex.Message });
            }
        }



        [HttpGet("GetUserByUserId/{userID}")]
        [Authorize]
        public async Task<IActionResult> GetProfile(Guid userID)
        {
            try
            {
                
                var result = await _userService.GetProfile(userID);
                if (result == null)
                {
                    return NotFound(new { message = "No user found." });
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while fetching user profile.", error = ex.Message });
            }
        }


        [HttpPut("EditProfile")]
        [Authorize(Roles = "Customer,Staff,Admin")]
        public async Task<IActionResult> EditProfile([FromBody] UserEditDto user)
        {
            
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Values
                        .SelectMany(v => v.Errors)
                        .Select(e => e.ErrorMessage)
                        .ToList();
                    return BadRequest(new { errors });
                }

                var result = await _userService.EditProfile(user);

                if (result is NotFoundObjectResult notFoundResult)
                {
                    return NotFound(notFoundResult.Value);
                }

                if (result is BadRequestObjectResult badRequestResult)
                {
                    return BadRequest(badRequestResult.Value);
                }

                if (result is OkObjectResult okResult)
                {
                    return Ok(okResult.Value);
                }

                return StatusCode(500, new { message = "Unexpected error occurred." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Server error", error = ex.Message });
            }
        }


        [HttpPost("Follow/{followId}")]
        [AuthorizeRole("Customer")]
        public async Task<IActionResult> Follow(Guid followId)
        {
            try
            {
                var curentUserId = JwtHelper.GetUserIdFromClaims(User);
                var result = await _userService.Follow(followId, curentUserId);

                if (!result)
                    return BadRequest("Unable to follow user.");

                return Ok("Follow successful.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpPut("Unfollow/{followId}")]
        [AuthorizeRole("Customer")]
        public async Task<IActionResult> Unfollow(Guid followId)
        {
            try
            {
                var curentUserId = JwtHelper.GetUserIdFromClaims(User);
                var result = await _userService.Unfollow(followId, curentUserId);

                if (!result)
                    return BadRequest("Unable to unfollow user.");

                return Ok("Unfollow successful.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }


        [HttpGet("{userId}/bookmarks")]
        public async Task<IActionResult> GetBookmarksByUserId(Guid userId)
        {
            try
            {
                var result = await _postService.GetBookmarksByUserId(userId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpGet("{userId}/comments")]
        public async Task<IActionResult> GetCommentsByUserId(Guid userId)
        {
            try
            {
                var result = await _postService.GetCommentsByUserId(userId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPut("ressetpassword")]
        public async Task<IActionResult> ResetPassword([FromBody] UserDtoWithEmailPass changePasswordDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Values
                        .SelectMany(v => v.Errors)
                        .Select(e => e.ErrorMessage)
                        .ToList();
                    return BadRequest(new { errors });
                }

                var result = await _userService.ResetPassword(changePasswordDto.Email, changePasswordDto.Password);

                if (!result)
                {
                    return NotFound("Not found email.");
                }

                return Ok("Password change successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpPut("changepassword")]
        [Authorize(Roles = "Customer,Staff,Admin")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordDto dto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Values
                        .SelectMany(v => v.Errors)
                        .Select(e => e.ErrorMessage)
                        .ToList();
                    return BadRequest(new { errors });
                }

                string result = await _userService.ChangePassword(dto.Id, dto.OldPassword, dto.NewPassword);

                if (result == "User not found")
                {
                    return NotFound(result);
                }
                if (result == "Old password is incorrect")
                {
                    return BadRequest(result);
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }



        [HttpGet("GetAddressByUserId")]
        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> GetAddressesByUserId()
        {
            try
            {
                var curentUserId = JwtHelper.GetUserIdFromClaims(User);
                var addresses = await _userService.ShowAddressByUserId(curentUserId);

                if (addresses == null || addresses.Count == 0)
                {
                    return NotFound("No addresses found for the given user.");
                }

                return Ok(addresses);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpPost("CreateAddress")]
        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> CreateAddress([FromBody] AddressCreateEditDto addressDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Values
                        .SelectMany(v => v.Errors)
                        .Select(e => e.ErrorMessage)
                        .ToList();
                    return BadRequest(new { errors });
                }

                var curentUserId = JwtHelper.GetUserIdFromClaims(User);
                var result = await _userService.CreateAddressByUserId(curentUserId, addressDto);

                if (!result)
                {
                    return NotFound("User not found or unable to create address.");
                }

                return Ok("Address created successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpPut("EditAddress/{addressId}")]
        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> EditAddress(Guid addressId, [FromBody] AddressCreateEditDto addressDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Values
                        .SelectMany(v => v.Errors)
                        .Select(e => e.ErrorMessage)
                        .ToList();
                    return BadRequest(new { errors });
                }

                var curentUserId = JwtHelper.GetUserIdFromClaims(User);
                var result = await _userService.EditAddress(curentUserId, addressId, addressDto);

                if (result)
                {
                    return Ok("Address updated successfully.");
                }

                return NotFound("Address not found or cannot be updated.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpDelete("DeleteAddress/{addressId}")]
        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> DeleteAddress(Guid addressId)
        {
            try
            {
                var curentUserId = JwtHelper.GetUserIdFromClaims(User);
                var result = await _userService.DeleteAddress(curentUserId, addressId);

                if (!result)
                {
                    return NotFound("Address not found or already deleted.");
                }

                return Ok(new
                {
                    Message = "Address deleted successfully."
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpGet("vouchers")]
        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> GetVouchersByUser([FromQuery] UserVoucherPaginationParams.UserFilter paginationParams)
        {
            try
            {
                paginationParams.UserId = JwtHelper.GetUserIdFromClaims(User);
                var userId = JwtHelper.GetUserIdFromClaims(User);
                var paginatedVouchers = await _userService.ShowUserVouchers(userId,paginationParams);
                return Ok(paginatedVouchers);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpGet("findemail")]
        public async Task<IActionResult> FindEmailByPhone([FromQuery] PhoneNumberRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var firstError = ModelState.Values
                        .SelectMany(v => v.Errors)
                        .FirstOrDefault()?.ErrorMessage;

                    return BadRequest(new { error = firstError });
                }

                var email = await _userService.FindEmailByPhone(request.PhoneNumber);
                if (email == null)
                {
                    return NotFound(new { error = "No user found with this phone number." });
                }

                return Ok(new { email });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }



        [HttpDelete("DeleteUser/{userID}")]
        [Authorize(Roles = "Customer,Staff,Admin")]
        public async Task<IActionResult> DeleteUser(Guid userID)
        {
            try
            {
                await _userService.DeleteUser(userID, true);
                return Ok("User deleted successfully");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error deleting user: {ex.Message}");
            }
        }

    

    }
}
