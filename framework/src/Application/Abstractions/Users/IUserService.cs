using System.Threading.Tasks;
using CoreBoilerplate.Application.Abstractions.DI;
using CoreBoilerplate.Application.Requests.Users;
using CoreBoilerplate.Application.Wrapper;

namespace CoreBoilerplate.Application.Interfaces.Services.Users
{
    public interface IUserService 
    {
        Task<IResult> RegisterAsync(RegisterRequest request, string origin);

        Task<IResult<string>> ConfirmEmailAsync(string userId, string code);

        Task<IResult> ForgotPasswordAsync(string emailId, string origin);

        Task<IResult> ResetPasswordAsync(ResetPasswordRequest request);
    }
}