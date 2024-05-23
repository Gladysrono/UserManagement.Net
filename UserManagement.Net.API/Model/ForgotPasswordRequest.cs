using System.ComponentModel.DataAnnotations;

namespace UserManagement.Net.API.Models
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
    }
}
