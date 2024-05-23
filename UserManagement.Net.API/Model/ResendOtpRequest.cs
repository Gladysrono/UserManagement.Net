using System.ComponentModel.DataAnnotations;

namespace UserManagement.Net.API.Models
{
    public class ResendOtpRequest
    {
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
    }
}
