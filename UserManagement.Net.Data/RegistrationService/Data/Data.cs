
namespace RegistrationService.Data
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