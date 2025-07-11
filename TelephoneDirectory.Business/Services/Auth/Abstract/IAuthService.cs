using TelephoneDirectory.Business.Services.Auth.Models.Request;
using TelephoneDirectory.Business.Services.Auth.Models.Response;

namespace TelephoneDirectory.Business.Services.Auth.Abstract
{
    public interface IAuthService
    {
               Task<LoginUserResponseModel> LoginAsync(LoginUserRequestModel request);
               Task RegisterAsync(RegistrationUserRequestModel request);
    }
}