using TelephoneDirectory.Business.Services.Auth.Abstract;
using TelephoneDirectory.Business.Services.Auth.Models.Request;
using TelephoneDirectory.Business.Services.Auth.Models.Response;

namespace TelephoneDirectory.Business.Services.Auth.Concrete
{
    public class AuthService : IAuthService
    {
        public async Task<LoginUserResponseModel> LoginAsync(LoginUserRequestModel request)
        {
            throw new NotImplementedException();
        }

        public async Task RegisterAsync(RegistrationUserRequestModel request)
        {
            throw new NotImplementedException();
        }
    }
}
