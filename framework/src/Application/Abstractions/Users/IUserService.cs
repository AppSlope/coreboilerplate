using CoreBoilerplate.Application.Requests.Users;
using CoreBoilerplate.Application.Wrapper;
using System.Threading.Tasks;

namespace CoreBoilerplate.Application.Interfaces.Services.Users
{
    public interface IUserService
    {
        Task<IResult> RegisterAsync(RegisterRequest request, string origin);

        Task<IResult<int>> ConfirmEmailAsync(int userId, string code);

        Task<IResult> ForgotPasswordAsync(string emailId, string origin);

        Task<IResult> ResetPasswordAsync(ResetPasswordRequest request);
    }
}