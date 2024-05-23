using Microsoft.EntityFrameworkCore;
using RegistrationService.Service.Entities;

namespace UserManagement.Net.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Otp> Otps { get; set; }
    }

    public class Otp
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        // Other properties...
    }
}
