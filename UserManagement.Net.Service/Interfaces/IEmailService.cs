using System.Threading.Tasks;

namespace UserManagement.Net.Service.Interfaces
{
    public interface IEmailService
    {
        Task SendForgotPasswordEmailAsync(string email, object otp);
        Task SendOtpAsync(string email, string otp);
        Task SendOtpEmailAsync(string email, object otp);
    }
}
