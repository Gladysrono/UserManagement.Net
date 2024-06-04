using System.ComponentModel.DataAnnotations;

namespace RegistrationService.Service.Entities
{
    public class User(string username, string password)
    {
        [Key]
        public int Id { get; set; }


        public string Username { get; set; } = username;


        public string Password { get; set; } = password;


        [EmailAddress]
        public string Email { get; set; }=string.Empty;

        // Additional properties
    }
}
