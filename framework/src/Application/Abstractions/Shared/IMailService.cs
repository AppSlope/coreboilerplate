using System.Threading.Tasks;
using CoreBoilerplate.Application.Abstractions.DI;
using CoreBoilerplate.Application.Requests.Shared;

namespace CoreBoilerplate.Application.Interfaces.Services.Shared
{
    public interface IMailService 
    {
        Task SendAsync(MailRequest request);
    }
}