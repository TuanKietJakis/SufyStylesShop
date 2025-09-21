using BussinessObject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepository
{
    public interface IInfoPageRepository
    {
        // StaticPage Methods
        Task<List<StaticPage>> GetAllStaticPages();
        Task UpdateStaticPage(StaticPage page);

        // FAQ Methods
        Task<List<FAQ>> GetAllFAQs();
        Task UpdateFAQ(FAQ faq);

        // Banner Methods
        Task<List<Banner>> GetAllBanners();
        Task AddBanner(Banner banner);
        Task UpdateBanner(Banner banner);

        Task<StaticPage?> GetStaticPageById(Guid id);
        Task<FAQ?> GetFAQById(Guid id);
        Task<Banner?> GetBannerById(Guid id);

        Task<List<ContactForm>> GetAllContactForms();
        Task CreateContactForm(ContactForm contactForm);
        Task UpdateContactForm(ContactForm contactForm);
        Task<ContactForm?> GetContactFormById(Guid id);
    }
}
