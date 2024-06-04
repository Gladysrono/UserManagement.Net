using System.Threading.Tasks;

namespace UserManagement.Net.Service.Interfaces
{
    public interface IUserService
    {
        Task RegisterUserAsync(string username, string password, string email);
        Task<bool> VerifyOtpAsync(string email, string otp);
        Task ForgotPasswordAsync(string email);
        Task<bool> ResetPasswordAsync(string email, string otp, string newPassword);
        Task ResendOtpAsync(string email);
        Task<string> LoginUserAsync(string username, string password);
        
    }
}
