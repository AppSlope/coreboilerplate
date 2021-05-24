using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor;
using MudBlazor.Services;
using System;
using System.Globalization;
using System.Net.Http;

namespace CoreBoilerplate.UI.Blazor.Extensions
{
    public static class WebAssemblyHostBuilderExtensions
    {
        private const string ClientName = "CoreBoilerplate.API";

        public static WebAssemblyHostBuilder AddRootComponents(this WebAssemblyHostBuilder builder)
        {
            builder.RootComponents.Add<App>("#app");

            return builder;
        }

        public static WebAssemblyHostBuilder AddClientServices(this WebAssemblyHostBuilder builder)
        {
            builder
                .Services
                .AddMudServices(configuration =>
                {
                    configuration.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomRight;
                    configuration.SnackbarConfiguration.HideTransitionDuration = 100;
                    configuration.SnackbarConfiguration.ShowTransitionDuration = 100;
                    configuration.SnackbarConfiguration.VisibleStateDuration = 3000;
                    configuration.SnackbarConfiguration.ShowCloseIcon = false;
                })
                .AddScoped(sp => sp
                    .GetRequiredService<IHttpClientFactory>()
                    .CreateClient(ClientName))
                    .AddHttpClient(ClientName, client =>
                    {
                        client.DefaultRequestHeaders.AcceptLanguage.Clear();
                        client.DefaultRequestHeaders.AcceptLanguage.ParseAdd(CultureInfo.DefaultThreadCurrentCulture?.TwoLetterISOLanguageName);
                        client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
                    });
          return builder;
        }

        public static IServiceCollection AddManagers(this IServiceCollection services)
        {
            return services;
        }
    }
}
