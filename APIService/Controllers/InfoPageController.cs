using APIService.Extension;
using APIService.Service;
using BussinessObject.DTO.InfoPage;
using BussinessObject.Model;
using BussinessObject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfoPageController : ControllerBase
    {
        private readonly InfoPageService _infoPageService;

        public InfoPageController(InfoPageService infoPageService)
        {
            _infoPageService = infoPageService;
        }

        // Static Pages
        [HttpGet("StaticPage/GetAll")]
        public async Task<IActionResult> GetAllStaticPages()
        {
            try
            {
                var pages = await _infoPageService.GetAllStaticPages();
                return Ok(pages);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while retrieving static pages.", Error = ex.Message });
            }
        }

        [HttpPut("StaticPage/Update")]
        [Authorize(Roles = "Staff,Admin")]
        public async Task<IActionResult> UpdateStaticPage(UpdateStaticPageDto pageDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
                    return BadRequest(new { errors });
                }

                var currentUserId = JwtHelper.GetUserIdFromClaims(User);
                pageDto.UpdatedUserId = currentUserId;

                await _infoPageService.UpdateStaticPage(pageDto);
                return Ok("Static Page updated successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while updating the static page.", Error = ex.Message });
            }
        }

        // FAQs
        [HttpGet("FAQ/GetAll")]
        public async Task<IActionResult> GetAllFAQs()
        {
            try
            {
                var faqs = await _infoPageService.GetAllFAQs();
                return Ok(faqs);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while retrieving FAQs.", Error = ex.Message });
            }
        }

        [HttpPut("FAQ/Update")]
        [Authorize(Roles = "Staff,Admin")]
        public async Task<IActionResult> UpdateFAQ(UpdateFAQDto faq)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
                    return BadRequest(new { errors });
                }

                var currentUserId = JwtHelper.GetUserIdFromClaims(User);
                faq.UpdatedUserId = currentUserId;
                await _infoPageService.UpdateFAQ(faq);
                return Ok("FAQ updated successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while updating the FAQ.", Error = ex.Message });
            }
        }

        // Banners
        [HttpGet("Banner/GetAll")]
        public async Task<IActionResult> GetAllBanners()
        {
            try
            {
                var banners = await _infoPageService.GetAllBanners();
                return Ok(banners);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while retrieving banners.", Error = ex.Message });
            }
        }

        [HttpPost("Banner/Create")]
        public async Task<IActionResult> CreateBanner([FromBody] CreateBannerDto dto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
                    return BadRequest(new { errors });
                }

                var currentUserId = JwtHelper.GetUserIdFromClaims(User);
                await _infoPageService.CreateBanner(dto, currentUserId);

                return Ok("Banner created successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while creating the banner.", Error = ex.Message });
            }
        }

        [HttpPut("Banner/Update")]
        [Authorize(Roles = "Staff,Admin")]
        public async Task<IActionResult> UpdateBanner(UpdateBannerDto bannerDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
                    return BadRequest(new { errors });
                }

                var currentUserId = JwtHelper.GetUserIdFromClaims(User);
                bannerDto.UserId = currentUserId;

                await _infoPageService.UpdateBanner(bannerDto);
                return Ok("Banner updated successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while updating the banner.", Error = ex.Message });
            }
        }

        [HttpGet("ShowContactForm")]
        public async Task<IActionResult> GetAllContactForms()
        {
            try
            {
                var forms = await _infoPageService.GetAllContactForms();
                return Ok(forms);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while retrieving contact forms.", Error = ex.Message });
            }
        }

        [HttpPost("SendContactForm")]
        public async Task<IActionResult> CreateContactForm([FromBody] CreateContactFormDto contactFormDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
                    return BadRequest(new { errors });
                }

                var createdForm = await _infoPageService.CreateContactForm(contactFormDto);
                return Ok(new { message = "Send success", contactFormId = createdForm.Id });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while sending the contact form.", Error = ex.Message });
            }
        }

        [HttpPost("SendContactForm/Update")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateContactForm(UpdateContactFormDto formDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
                    return BadRequest(new { errors });
                }

                var currentUserId = JwtHelper.GetUserIdFromClaims(User);
                formDto.UserId = currentUserId;
                await _infoPageService.UpdateContactForm(formDto);
                return Ok("Update successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while updating the contact form.", Error = ex.Message });
            }
        }
    }
}
