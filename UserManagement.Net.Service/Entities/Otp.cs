using System;

namespace UserManagement.Net.Service.Entities
{
    public class Otp
    {
        public string? Email { get; set; }
        public string? Code { get; set; }
        public DateTime Expiration { get; set; }
    }
}
