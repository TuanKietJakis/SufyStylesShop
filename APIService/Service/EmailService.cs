using APIService.Extension;
using BussinessObject.Services.Mail;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using static System.Net.WebRequestMethods;

namespace APIService.Service
{
    public class EmailService
    {
        private readonly EmailSettings emailSettings;

        public EmailService(IOptions<EmailSettings> options)
        {
            this.emailSettings = options.Value;
        }

        private async Task SendEmail(MailRequest mailrequest)
        {
            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse(emailSettings.Email);
            email.To.Add(MailboxAddress.Parse(mailrequest.Email));
            email.Subject = mailrequest.Subject;

            var builder = new BodyBuilder
            {
                HtmlBody = mailrequest.Body
            };
            email.Body = builder.ToMessageBody();
            using var smtp = new SmtpClient();
            try
            {
                smtp.Connect(emailSettings.Host, emailSettings.Port, SecureSocketOptions.StartTls);
                smtp.Authenticate(emailSettings.Email, emailSettings.Password);
                await smtp.SendAsync(email);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending email: {ex.Message}");
                throw;
            }
            finally
            {
                smtp.Disconnect(true);
            }
        }

        private string Generaterandomnumber()
        {
            Random random = new Random();
            string randomno = random.Next(0, 1000000).ToString("D6");
            return randomno;
        }

        public async Task<string> SendOtpMailForgetPass(string useremail)
        {
            var mailrequest = new MailRequest();
            string otp = Generaterandomnumber();
            mailrequest.Email = useremail;
            mailrequest.Subject = "Forget Password: OTP";
            mailrequest.Body = GenerateEmailBody(otp);
            await SendEmail(mailrequest);
            Console.WriteLine("OTP Text is: " + otp);
            OtpStorage.StoreOtp(useremail, otp);
            return "OTP sent to your email.";
        }  
        public async Task<string> SendOtpMailRegister(string useremail)
        {
            var mailrequest = new MailRequest();
            string otp = Generaterandomnumber();
            mailrequest.Email = useremail;
            mailrequest.Subject = "Register: OTP";
            mailrequest.Body = GenerateEmailBody(otp);
            await SendEmail(mailrequest);
            Console.WriteLine("OTP Text is: " + otp);
            OtpStorage.StoreOtp(useremail, otp);
            return "OTP sent to your email.";
        }

        private string GenerateEmailBody(string otptext)
        {
            string emailbody = "<div style='width:100%;background-color:grey'>";
            emailbody += "<h1>Hi, Thanks for using my service</h1>";
            emailbody += "<h2>Please enter OTP text and complete the registeration</h2>";
            emailbody += "<h2>OTP Text is: " + otptext + "</h2>";
            emailbody += "</div>";

            return emailbody;
        }

        public async Task<string> VerifyOtp(string email, string otp)
        {
            var otpInfo = OtpStorage.GetOtp(email);

            if (otpInfo == null || otpInfo.Expiration < DateTime.UtcNow)
            {
                return "Invalid or expired OTP.";
            }

            if (otpInfo.Otp != otp)
            {
                return "Invalid OTP.";
            }
            OtpStorage.ClearOtp(email); 
            return "OTP verified.";
        }

      
    }
}
