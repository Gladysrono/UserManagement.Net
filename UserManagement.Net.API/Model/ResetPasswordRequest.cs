using System.ComponentModel.DataAnnotations;

namespace UserManagement.Net.API.Models
{
    public class ResetPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string? Otp { get; set; }

        [Required]
        public string? NewPassword { get; set; }
    }
}
