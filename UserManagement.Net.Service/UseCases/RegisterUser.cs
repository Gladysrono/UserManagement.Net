﻿using System;
using System.Threading.Tasks;
using UserManagement.Net.Service.Services;

namespace UserManagement.Net.Service.UseCases
{
    public class RegisterUser(RegisterUser.IUserRepository userRepository, PasswordHasher passwordHasher) : IRegistrationService
    {
        private readonly IUserRepository _userRepository = userRepository;
        private readonly PasswordHasher _passwordHasher = passwordHasher;

        public async Task RegisterUserAsync(string username, string password, string email)
        {
            var hashedPassword = PasswordHasher.HashPassword(password);
            await _userRepository.CreateUserAsync(username, hashedPassword, email);
        }

        // Other methods...

        // Ensure the IUserRepository interface is public
        public interface IUserRepository
        {
            Task CreateUserAsync(string username, string hashedPassword, string email);
        }
    }

    public interface IRegistrationService
    {
    }
}
