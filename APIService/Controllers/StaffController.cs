using APIService.Extension;
using APIService.Service;
using BussinessObject.DTO.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APIService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class StaffController : ControllerBase
    {
       
        private readonly UserService _userService;
        private readonly AccountManageService _accountManageService;
    

        public StaffController(UserService userService, AccountManageService accountManageService)
        {
            _userService = userService;
            _accountManageService = accountManageService;
        }

       
        [HttpGet("GetAllUser")]
        [Authorize(Roles = "Customer,Staff,Admin")]
        public async Task<IActionResult> GetUsers()
        {
            try
            {
                var staffUsers = await _accountManageService.GetUsersByRole("Customer");
                return Ok(staffUsers);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error fetching staff users: {ex.Message}");
            }
        }

        [HttpPost("CreateUser")]
        [Authorize(Roles = "Staff,Admin")]
        public async Task<IActionResult> CreateUser([FromBody] RegisterAccountModel registerData)
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
                return BadRequest(new { message = ex.Message });
            }
        }

      

        [HttpDelete("BanUser/{userID}/{isBan}")]
        [Authorize(Roles = "Staff,Admin")]
        public async Task<IActionResult> BanUser(Guid userID, bool isBan)
        {
            try
            {
                await _userService.BanUser(userID, isBan);
                return Ok("User banned successfully");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error deleting user: {ex.Message}");
            }
        } 
        [HttpDelete("DeleteUser/{userID}/{isDelete}")]
        [Authorize(Roles = "Staff,Admin")]
        public async Task<IActionResult> DeleteUser(Guid userID, bool isDelete)
        {
            try
            {
                await _userService.DeleteUser(userID, isDelete);
                return Ok("User deleted successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error deleting user: {ex.Message}");
            }
        }

    }
}
