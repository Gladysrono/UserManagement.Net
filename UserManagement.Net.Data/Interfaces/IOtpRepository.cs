using System.Threading.Tasks;
using UserManagement.Net.Service.Entities;

namespace UserManagement.Net.Data.Interfaces
{
    public interface IOtpRepository
    {
        Task SaveAsync(Otp otp);
        Task<Otp> GetByEmailAsync(string email);
        
        


       
    }
}
