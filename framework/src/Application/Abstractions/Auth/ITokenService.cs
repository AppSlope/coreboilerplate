using CoreBoilerplate.Application.Requests.Auth;
using CoreBoilerplate.Application.Responses.Auth;
using CoreBoilerplate.Application.Wrapper;
using System.Threading.Tasks;

namespace CoreBoilerplate.Application.Interfaces.Services.Auth
{
    public interface ITokenService
    {
        Task<IResult<TokenResponse>> GetTokenAsync(TokenRequest model, string ipAddress);

        Task<IResult<TokenResponse>> RefreshTokenAsync(RefreshTokenRequest model, string ipAddress);
    }
}