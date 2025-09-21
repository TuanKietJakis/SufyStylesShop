using BussinessObject.Model;
using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BussinessObject.SeedData
{
    public static class SeedDataFAQ
    {
        public static readonly FAQ[] FAQs = new FAQ[]
        {
            new FAQ
            {
                Id = Guid.NewGuid(),
                Category = "Shopping & Orders",
                Question = "How do I place an order?",
                Answer = "To place an order, simply browse our products, select your desired items, add them to your cart, and proceed to checkout. Follow the steps to enter your shipping and payment information to complete your purchase.",
                UpdatedUserId = new Guid("3F1A7D9B-8E2C-4D5A-9B2F-6C8D4E1F5A3C")
            },
            new FAQ
            {
                Id = Guid.NewGuid(),
                Category = "Shopping & Orders",
                Question = "What payment methods do you accept?",
                Answer = "We accept various payment methods including credit/debit cards (Visa, MasterCard, American Express), PayPal, and other local payment options.",
                 UpdatedUserId = new Guid("3F1A7D9B-8E2C-4D5A-9B2F-6C8D4E1F5A3C")
            },
            new FAQ
            {
                Id = Guid.NewGuid(),
                Category = "Shopping & Orders",
                Question = "How can I track my order?",
                Answer = "Once your order is shipped, you'll receive a tracking number via email. You can use this number to track your package through our website or the carrier's website.",
                UpdatedUserId = new Guid("3F1A7D9B-8E2C-4D5A-9B2F-6C8D4E1F5A3C")
            },
            new FAQ
            {
                Id = Guid.NewGuid(),
                Category = "Returns & Refunds",
                Question = "What is your return policy?",
                Answer = "We offer a 30-day return policy for most items. Products must be unused, in their original packaging, and in the same condition as received.",
                UpdatedUserId = new Guid("3F1A7D9B-8E2C-4D5A-9B2F-6C8D4E1F5A3C")
            },
            new FAQ
            {
                Id = Guid.NewGuid(),
                Category = "Returns & Refunds",
                Question = "How do I initiate a return?",
                Answer = "To initiate a return, log into your account, go to your order history, select the order containing the item you wish to return, and follow the return instructions.",
                UpdatedUserId = new Guid("3F1A7D9B-8E2C-4D5A-9B2F-6C8D4E1F5A3C")
            },
            new FAQ
            {
                Id = Guid.NewGuid(),
                Category = "Returns & Refunds",
                Question = "When will I receive my refund?",
                Answer = "Refunds are typically processed within 5-7 business days after we receive your return. The time it takes for the refund to appear in your account depends on your payment method and financial institution.",
                UpdatedUserId = new Guid("3F1A7D9B-8E2C-4D5A-9B2F-6C8D4E1F5A3C")
            },
            new FAQ
            {
                Id = Guid.NewGuid(),
                Category = "Account & Profile",
                Question = "How do I create an account?",
                Answer = "Click the 'Sign Up' button on our website and fill in the required details, including your name, email, and password. Once completed, you'll receive a confirmation email to activate your account.",
                UpdatedUserId = new Guid("3F1A7D9B-8E2C-4D5A-9B2F-6C8D4E1F5A3C")
            },
            new FAQ
            {
                Id = Guid.NewGuid(),
                Category = "Account & Profile",
                Question = "How can I reset my password?",
                Answer = "Click the 'Forgot Password' link on the login page. Enter your email address, and we'll send you instructions to reset your password.",
                UpdatedUserId = new Guid("3F1A7D9B-8E2C-4D5A-9B2F-6C8D4E1F5A3C")
            },
            new FAQ
            {
                Id = Guid.NewGuid(),
                Category = "Account & Profile",
                Question = "Can I edit my profile information?",
                Answer = "Yes, you can edit your profile information at any time. Simply log into your account, go to your profile settings, and update your information as needed.",
                UpdatedUserId = new Guid("3F1A7D9B-8E2C-4D5A-9B2F-6C8D4E1F5A3C")
            },
            new FAQ
            {
                Id = Guid.NewGuid(),
                Category = "Social Features",
                Question = "How do I create a post?",
                Answer = "To create a post, click the '+' button on the navigation bar, select your photos/videos, add a description, and click 'Post'. You can also tag products and add locations to your posts.",
                UpdatedUserId = new Guid("3F1A7D9B-8E2C-4D5A-9B2F-6C8D4E1F5A3C")
            },
            new FAQ
            {
                Id = Guid.NewGuid(),
                Category = "Social Features",
                Question = "Can I edit or delete my posts?",
                Answer = "Yes, you can edit or delete your posts at any time. Go to the post you want to modify, click the three dots menu, and select 'Edit' or 'Delete'.",
                UpdatedUserId = new Guid("3F1A7D9B-8E2C-4D5A-9B2F-6C8D4E1F5A3C")
            },
            new FAQ
            {
                Id = Guid.NewGuid(),
                Category = "Social Features",
                Question = "How do I follow other users?",
                Answer = "To follow another user, visit their profile and click the 'Follow' button. You'll then see their posts in your feed and receive updates about their activity.",
                UpdatedUserId = new Guid("3F1A7D9B-8E2C-4D5A-9B2F-6C8D4E1F5A3C")
            }
        };

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FAQ>().HasData(FAQs);
        }
    }
}
