using BussinessObject.Model;
using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class InfoPageRepository : IInfoPageRepository
    {
        private readonly SufyStylesShopContext _context;

        public InfoPageRepository(SufyStylesShopContext context)
        {
            _context = context;
        }

        // StaticPage Methods
        public async Task<List<StaticPage>> GetAllStaticPages()
        {
            return await _context.StaticPages.Include(p => p.UpdatedByUser).ToListAsync();
        }

        public async Task AddStaticPage(StaticPage page)
        {
            await _context.StaticPages.AddAsync(page);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateStaticPage(StaticPage page)
        {
            _context.StaticPages.Update(page);
            await _context.SaveChangesAsync();
        }


        // FAQ Methods
        public async Task<List<FAQ>> GetAllFAQs()
        {
            return await _context.FAQs.Include(f => f.UpdatedByUser).ToListAsync();
        }

        public async Task AddFAQ(FAQ faq)
        {
            await _context.FAQs.AddAsync(faq);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateFAQ(FAQ faq)
        {
            _context.FAQs.Update(faq);
            await _context.SaveChangesAsync();
        }

        // Banner Methods
        public async Task<List<Banner>> GetAllBanners()
        {
            return await _context.Banners.Include(b => b.User).ToListAsync();
        }

        public async Task AddBanner(Banner banner)
        {
            await _context.Banners.AddAsync(banner);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBanner(Banner banner)
        {
            _context.Banners.Update(banner);
            await _context.SaveChangesAsync();
        }

        public async Task<StaticPage?> GetStaticPageById(Guid id)
        {
            return await _context.StaticPages.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<FAQ?> GetFAQById(Guid id)
        {
            return await _context.FAQs.FirstOrDefaultAsync(f => f.Id == id);
        }
        public async Task<Banner?> GetBannerById(Guid id)
        {
            return await _context.Banners.FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<List<ContactForm>> GetAllContactForms()
        {
            return await _context.ContactForms
                .Include(c => c.User)
                .OrderByDescending(c => c.CreatedAt)
                .ToListAsync();
        }

        public async Task CreateContactForm(ContactForm contactForm)
        {
            await _context.ContactForms.AddAsync(contactForm);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateContactForm(ContactForm contactForm)
        {
            _context.ContactForms.Update(contactForm);
            await _context.SaveChangesAsync();
        }

        public async Task<ContactForm?> GetContactFormById(Guid id)
        {
            return await _context.ContactForms.FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
