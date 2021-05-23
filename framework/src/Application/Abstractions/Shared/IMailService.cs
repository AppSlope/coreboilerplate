using CoreBoilerplate.Application.Requests.Shared;
using System.Threading.Tasks;

namespace CoreBoilerplate.Application.Interfaces.Services.Shared
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}