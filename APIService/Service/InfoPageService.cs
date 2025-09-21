using BussinessObject.DTO.InfoPage;
using BussinessObject.Model;
using BussinessObject.Models;
using ISUZU_NEXT.Server.Core.Extentions;
using Microsoft.EntityFrameworkCore;
using Repositories.IRepository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Service
{
    public class InfoPageService 
    {
        private readonly IInfoPageRepository _infoPageRepository;

        public InfoPageService(IInfoPageRepository infoPageRepository)
        {
            _infoPageRepository = infoPageRepository;
        }

        // StaticPage Methods
        public async Task<List<StaticPage>> GetAllStaticPages()
        {
            return await _infoPageRepository.GetAllStaticPages();
        }

        public async Task UpdateStaticPage(UpdateStaticPageDto pageDto)
        {
            var existingPage = await _infoPageRepository.GetStaticPageById(pageDto.Id);
            if (existingPage == null)
            {
                throw new Exception("Static Page not found");
            }

            existingPage.CopyProperties(pageDto);
            existingPage.UpdateDate = DateTime.Now;
            await _infoPageRepository.UpdateStaticPage(existingPage);
        }

        // FAQ Methods
        public async Task<List<FAQ>> GetAllFAQs()
        {
            return await _infoPageRepository.GetAllFAQs();
        }

        public async Task UpdateFAQ(UpdateFAQDto faqDto)
        {
            var existingFAQ = await _infoPageRepository.GetFAQById(faqDto.Id);
            if (existingFAQ == null)
            {
                throw new Exception("FAQ not found");
            }

            existingFAQ.CopyProperties(faqDto);
            existingFAQ.UpdateDate = DateTime.Now;

            await _infoPageRepository.UpdateFAQ(existingFAQ);
        }

        // Banner Methods
        public async Task<List<Banner>> GetAllBanners()
        {
            return await _infoPageRepository.GetAllBanners();
        }

        public async Task CreateBanner(CreateBannerDto dto, Guid userId)
        {
            var banner = new Banner
            {
                Id = Guid.NewGuid(),
                Name = dto.Name,
                UrlImage = dto.UrlImage,
                IsVisible = dto.IsVisible,
                Position = dto.Position,
                CreatedAt = DateTime.UtcNow,
                UpdatedUserId = userId
            };

            await _infoPageRepository.AddBanner(banner);

        }

        public async Task UpdateBanner(UpdateBannerDto bannerDto)
        {
            var existingBanner = await _infoPageRepository.GetBannerById(bannerDto.Id);
            if (existingBanner == null)
            {
                throw new Exception("Banner not found");
            }

            existingBanner.CopyProperties(bannerDto);
            
            await _infoPageRepository.UpdateBanner(existingBanner);
        }

        public async Task<List<ContactForm>> GetAllContactForms()
        {
            return await _infoPageRepository.GetAllContactForms();
        }

        public async Task<ContactForm> CreateContactForm(CreateContactFormDto contactFormDto)
        {
            var contactForm = new ContactForm();
            contactForm.CopyProperties(contactFormDto);

            contactForm.Id = Guid.NewGuid();
            contactForm.CreatedAt = DateTime.UtcNow;
 
            await _infoPageRepository.CreateContactForm(contactForm);
            return contactForm;
        }

        public async Task UpdateContactForm(UpdateContactFormDto dto)
        {
            var existingForm = await _infoPageRepository.GetContactFormById(dto.Id);
            if (existingForm == null)
            {
                throw new Exception("Contact Form not found");
            }

            existingForm.CopyProperties(dto);

            await _infoPageRepository.UpdateContactForm(existingForm);
        }

    }
}
