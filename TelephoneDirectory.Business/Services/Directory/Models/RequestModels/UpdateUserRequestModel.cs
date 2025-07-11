using System.ComponentModel.DataAnnotations;

namespace TelephoneDirectory.Business.Services.Directory.Models.RequestModels
{
    class UpdateUserRequestModel
    {
        [Required(ErrorMessage = "User ID is required.")]
        public int Id { get; set; }
        [Required(ErrorMessage = "First name is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        public string PhoneNumber { get; set; }
        public string? Email { get; set; } = string.Empty;
        public string? Address { get; set; } = string.Empty;
    }
}
