using Blazored.LocalStorage;
using CoreBoilerplate.Shared.Settings;
using MudBlazor;
using System.Threading.Tasks;
using UI.Blazor.Infrastructure.Settings;

namespace UI.Blazor.Infrastructure.Manager.Preferences
{
    public class ClientPreferenceManager : IClientPreferenceManager
    {
        private readonly ILocalStorageService _localStorageService;

        public ClientPreferenceManager(ILocalStorageService localStorageService)
        {
            _localStorageService = localStorageService;
        }

        public async Task<bool> ToggleDarkModeAsync()
        {
            var preference = await GetPreference() as ClientPreference;
            if (preference != null)
            {
                preference.IsDarkMode = !preference.IsDarkMode;
                await SetPreference(preference);
                return !preference.IsDarkMode;
            }

            return false;
        }

        public async Task ChangeLanguageAsync(string languageCode)
        {
            var preference = await GetPreference() as ClientPreference;
            if (preference != null)
            {
                preference.LanguageCode = languageCode;
                await SetPreference(preference);
            }
        }

        public async Task<MudTheme> GetCurrentThemeAsync()
        {
            var preference = await GetPreference() as ClientPreference;
            if (preference != null)
            {
                if (preference.IsDarkMode == true) return ApplicationTheme.DarkTheme;
            }
            return ApplicationTheme.DefaultTheme;
        }

        public async Task<IPreference> GetPreference()
        {
            return await _localStorageService.GetItemAsync<ClientPreference>("clientPreference") ?? new ClientPreference();
        }

        public async Task SetPreference(IPreference preference)
        {
            await _localStorageService.SetItemAsync("clientPreference", preference as ClientPreference);
        }
    }
}
