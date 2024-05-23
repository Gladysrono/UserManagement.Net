using Microsoft.EntityFrameworkCore;

namespace UserManagement.Net.Data.Repositories
{
    public class OtpRepository(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public async Task AddOtpAsync(Otp otp)
        {
            await _context.Otps.AddAsync(otp);
            await _context.SaveChangesAsync();
        }

        public async Task<Otp> GetOtpByEmailAsync(string email)
        {
            return await _context.Otps.FirstOrDefaultAsync(o => o.Email == email);
        }
    }
}
