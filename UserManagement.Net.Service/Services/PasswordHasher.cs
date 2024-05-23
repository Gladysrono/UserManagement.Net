using Org.BouncyCastle.Crypto.Generators;

namespace UserManagement.Net.Service.Services
{
    public class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            // Implement password hashing logic here
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
    }
}
