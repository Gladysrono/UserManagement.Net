using RegistrationService.Service.Entities;

namespace RegistrationService.Data.Mappers
{
    public static class UserMapper
    {
        public static User ToEntity(UserDto userDto, string? username) => new(username, userDto.Password);

        public static UserDto ToDto(User user) => new() { Username = user.Username, Password = user.Password };
    }

    public class UserDto
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
