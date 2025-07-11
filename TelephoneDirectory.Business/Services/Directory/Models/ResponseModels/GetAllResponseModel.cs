using System.ComponentModel.DataAnnotations;

namespace TelephoneDirectory.Business.Services.Directory.Models.ResponseModels
{
    class GetAllResponseModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string? Email { get; set; } = string.Empty;
        public string? Address { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
    }
}
