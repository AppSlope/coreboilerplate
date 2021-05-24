using CoreBoilerplate.Shared.Managers;
using MudBlazor;
using System.Threading.Tasks;

namespace UI.Blazor.Infrastructure.Manager.Preferences
{
    public interface IClientPreferenceManager : IPreferenceManager, IManager
    {
        Task<MudTheme> GetCurrentThemeAsync();

        Task<bool> ToggleDarkModeAsync();

        Task ChangeLanguageAsync(string languageCode);
    }
}
