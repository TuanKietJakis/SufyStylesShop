using BussinessObject.Model;
using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BussinessObject.SeedData
{
    public static class SeedDataStaticPage
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StaticPage>().HasData(
                new StaticPage
                {
                    Id = Guid.NewGuid(),
                    Title = "Privacy Policy",
                    Content = @"
# Privacy Policy
We value your privacy and are committed to protecting your personal data. This privacy policy will inform you about how we handle your personal information.

## 1. Information We Collect
We collect several different types of information for various purposes to provide and improve our service to you:
- Personal identification information (Name, email address, phone number, etc.)
- Usage Data (Browser type, access time, pages visited)
- Transaction Data (Purchase history, payment details)
- User Content (Posts, comments, reviews)

## 2. How We Use Your Information
We use the collected data for various purposes:
- To provide and maintain our service
- To notify you about changes to our service
- To provide customer support
- To process your transactions
- To send you marketing and promotional communications (with your consent)
- To improve our service and user experience

## 3. Data Security
The security of your data is important to us. We implement appropriate security measures to protect against unauthorized access, alteration, disclosure, or destruction of your personal information.

However, please note that no method of transmission over the Internet or method of electronic storage is 100% secure. While we strive to use commercially acceptable means to protect your personal data, we cannot guarantee its absolute security.

## 4. Cookies and Tracking
We use cookies and similar tracking technologies to track activity on our platform and hold certain information. Cookies are files with small amounts of data which may include an anonymous unique identifier.

You can instruct your browser to refuse all cookies or to indicate when a cookie is being sent. However, if you do not accept cookies, you may not be able to use some portions of our service.

## 5. Third-Party Services
We may employ third-party companies and individuals to facilitate our service, provide service-related services, or assist us in analyzing how our service is used.

These third parties have access to your personal data only to perform these tasks on our behalf and are obligated not to disclose or use it for any other purpose.

## 6. Your Data Rights
Under certain circumstances, you have rights under data protection laws in relation to your personal data:
- The right to access your personal data
- The right to correct your personal data
- The right to erase your personal data
- The right to restrict processing of your personal data
- The right to data portability
- The right to object to processing of your personal data

## 7. Changes to This Policy
We may update our Privacy Policy from time to time. We will notify you of any changes by posting the new Privacy Policy on this page and updating the 'Last updated' date.

You are advised to review this Privacy Policy periodically for any changes. Changes to this Privacy Policy are effective when they are posted on this page.

## 8. Contact Us
If you have any questions about this Privacy Policy, please contact us at privacy@yourfashionsite.com."
                },
                new StaticPage
                {
                    Id = Guid.NewGuid(),
                    Title = "Terms of Service",
                    Content = @"

Please read these terms and conditions carefully before using our platform.

## 1. Acceptance of Terms
By accessing and using this website, you accept and agree to be bound by the terms and provision of this agreement. Additionally, when using this website's particular services, you shall be subject to any posted guidelines or rules applicable to such services.

## 2. User Account
To access certain features of the platform, you must register for an account. You agree to provide accurate, current, and complete information during the registration process and to update such information to keep it accurate, current, and complete.

You are responsible for safeguarding your password and for restricting access to your account from any devices. You agree to accept responsibility for all activities that occur under your account or password.

## 3. User Content
Our platform allows users to post, link, store, share, and otherwise make available certain information, text, graphics, videos, or other material. You are responsible for the content that you post to the platform, including its legality, reliability, and appropriateness.

By posting content to the platform, you grant us the right and license to use, modify, publicly perform, publicly display, reproduce, and distribute such content on and through the platform.

## 4. E-commerce
Products are subject to availability and we reserve the right to impose quantity limits on any order, reject all or any part of an order, and discontinue products without notice, even if you have already placed your order.

All prices are subject to change without notice. The prices displayed at the time of order placement will be the prices applied to the order.

## 5. Intellectual Property
The platform and its original content (excluding user-generated content), features, and functionality are and will remain the exclusive property of our company and its licensors. The platform is protected by copyright, trademark, and other laws.

## 6. Termination
We may terminate or suspend your account and bar access to the platform immediately, without prior notice or liability, under our sole discretion, for any reason whatsoever and without limitation, including but not limited to a breach of the Terms.

## 7. Changes to Terms
We reserve the right to modify these terms from time to time at our sole discretion. Therefore, you should review these pages periodically. Your continued use of the platform after any such change constitutes your acceptance of the new Terms of Service.

## 8. Contact Us
If you have any questions about these Terms, please contact us at legal@yourfashionsite.com."
                },
                new StaticPage
                {
                    Id = Guid.NewGuid(),
                    Title = "About Us",
                    Content = @"
# About Us
Welcome to YourFashionSite, your number one source for all things fashion. We're dedicated to giving you the very best of stylish clothing, with a focus on quality, customer service, and uniqueness.

## Our Story
Founded in 2023, YourFashionSite has come a long way from its beginnings. When we first started out, our passion for trendy yet affordable fashion drove us to start our own business, so that YourFashionSite can offer you the most stylish and high-quality fashion items.

## Our Mission
Our mission is to make fashion accessible and enjoyable for everyone. We believe that style should be personal, and we strive to provide a diverse collection of outfits that suit every personality and occasion.

## Contact Us
If you have any questions or feedback, feel free to reach out to us at contact@yourfashionsite.com."
                }

            );
        }
    }
}
