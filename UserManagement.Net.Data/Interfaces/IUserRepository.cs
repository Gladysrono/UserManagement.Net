using RegistrationService.Service.Entities;
using System.Threading.Tasks;

namespace UserManagement.Net.Data.Interfaces
{
    public interface IUserRepository
    {
        Task SaveAsync(User user);
        Task<User> GetByUsernameAsync(string username);
        Task<User> GetByEmailAsync(string email); // Fix the return type to Task<User>
        Task UpdateAsync(User user);
    }
}
