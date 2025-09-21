using APIService.Extension;
using APIService.Service;
using BussinessObject.DTO.Admin;
using BussinessObject.DTO.User;
using Microsoft.AspNetCore.Mvc;

namespace APIService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AuthorizeRole("Admin")]
    public class AdminController : ControllerBase
    {
        private readonly AccountManageService _adminService;
       
        public AdminController(AccountManageService adminService)
        {
            _adminService = adminService;
              
        }

        [HttpGet("GetAllUser")]
        public async Task<IActionResult> GetAllUsersWithRoles()
        {
            try
            {
                var users = await _adminService.GetAllUsers();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = ex.Message });
            }
        }

        [HttpGet("GetAllRole")]
        public async Task<IActionResult> GetAllRoles()
        {
            try
            {
                var roles = await _adminService.GetAllRoles();
                return Ok(roles);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = ex.Message });
            }
        }

        [HttpPut("ChangeRole/{userId}/{roleId}")]
        public async Task<IActionResult> ChangeUserRole(Guid userId, Guid roleId)
        {
            try
            {
                var result = await _adminService.UpdateUserRole(userId, roleId);
                if (!result)
                {
                    return BadRequest("User or Role not found");
                }
                return Ok("User role updated successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = ex.Message });
            }
        }



    }
}
