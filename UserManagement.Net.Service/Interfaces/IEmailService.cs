using System.Threading.Tasks;

namespace UserManagement.Net.Service.Interfaces
{
    public interface IEmailService
    {
        Task SendOtpAsync(string email, string otp);
    }
}
