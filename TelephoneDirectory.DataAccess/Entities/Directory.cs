
namespace TelephoneDirectory.DataAccess.Entities
{
    class Directory : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string? Email { get; set; } = string.Empty;
        public string? Address { get; set; } = string.Empty;

        internal static string GetCurrentDirectory()
        {
            throw new NotImplementedException();
        }
    }
}
