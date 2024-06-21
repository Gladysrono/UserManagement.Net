using Microsoft.EntityFrameworkCore;
using UserManagement.Net.Service.Interfaces;
using UserManagement.Net.Data; // Add this using directive

namespace UserManagement.Net.Service.Services
{
    internal class Data
    {
        internal class ApplicationDbContext
        {
            public object? Users { get; internal set; }

            internal Task SaveChangesAsync()
            {
                throw new NotImplementedException();
            }
        }
    }
}