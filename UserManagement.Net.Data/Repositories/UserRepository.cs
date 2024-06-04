using Microsoft.EntityFrameworkCore;
using RegistrationService.Service.Entities;
using UserManagement.Net.Data.Interfaces;
using System.Linq;
using System.Threading.Tasks;


namespace UserManagement.Net.Data.Repositories
{
    public class UserRepository(ApplicationDbContext context) : IUserRepository
    {
        private readonly ApplicationDbContext _context = context;

        public async Task SaveAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User> GetByUsernameAsync(string username)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
#pragma warning restore CS8603 // Possible null reference return.
        }

        public async Task<User> GetByEmailAsync(string email)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
#pragma warning restore CS8603 // Possible null reference return.
        }

        public async Task UpdateAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}
