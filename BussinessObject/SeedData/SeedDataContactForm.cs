using BussinessObject.Model;
using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BussinessObject.SeedData
{
    public static class SeedDataContactForm
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactForm>().HasData(
                new ContactForm
                {
                    Id = Guid.NewGuid(),
                    Name = "John Doe",
                    Email = "johndoe@example.com",
                    Subject = "Support Request",
                    Message = "I need help with my account.",
                    CreatedAt = DateTime.UtcNow,
                    FinishUserId = new Guid("3F2504E0-4F89-11D3-9A0C-0305E82C3301")
                },
                new ContactForm
                {
                    Id = Guid.NewGuid(),
                    Name = "Jane Smith",
                    Email = "janesmith@example.com",
                    Subject = "Billing Issue",
                    Message = "I was charged incorrectly on my last invoice.",
                    CreatedAt = DateTime.UtcNow,
                    FinishUserId = new Guid("3F2504E0-4F89-11D3-9A0C-0305E82C3301")
                },
                new ContactForm
                {
                    Id = Guid.NewGuid(),
                    Name = "Alice Johnson",
                    Email = "alicejohnson@example.com",
                    Subject = "Feature Request",
                    Message = "Can you add a dark mode to the platform?",
                    CreatedAt = DateTime.UtcNow,
                    FinishUserId = new Guid("72AB8BAE-9706-4709-9734-D6E986F539EA")
                }
            );
        }
    }
}
