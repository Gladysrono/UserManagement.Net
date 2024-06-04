using RegistrationService.Service.Entities;

namespace RegistrationService.Data.Mappers
{
    public static class UserMapper
    {
#pragma warning disable CS8604 // Possible null reference argument.
        public static User ToEntity(UserDto userDto, string username) => new(username, userDto.Password);
#pragma warning restore CS8604 // Possible null reference argument.

        public static UserDto ToDto(User user) => new() { Username = user.Username, Password = user.Password };
    }

    public class UserDto
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
