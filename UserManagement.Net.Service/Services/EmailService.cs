using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using UserManagement.Net.Service.Interfaces;

namespace UserManagement.Net.Service.Services
{
    public class EmailService : IEmailService
    {
        public async Task SendOtpAsync(string email, string otp)
        {
            using var smtp = new SmtpClient("smtp.example.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("your-email@example.com", "your-password"),
                EnableSsl = true,
            };

            var message = new MailMessage("your-email@example.com", email)
            {
                Subject = "Your OTP Code",
                Body = $"Your OTP code is: {otp}",
            };

            await smtp.SendMailAsync(message);
        }

        Task IEmailService.SendForgotPasswordEmailAsync(string email, object otp)
        {
            throw new NotImplementedException();
        }

        Task IEmailService.SendOtpAsync(string email, string otp)
        {
            throw new NotImplementedException();
        }

        Task IEmailService.SendOtpEmailAsync(string email, object otp)
        {
            throw new NotImplementedException();
        }
    }
}
