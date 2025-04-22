using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Refit;
using TaskManager.Api;
using TaskManager.Pages;
using TaskManager.ViewModels;

namespace TaskManager
{
    public static class MauiProgram
    {
        
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .UseMauiCommunityToolkit();

#if DEBUG
            builder.Logging.AddDebug();
#endif
            builder.Services.AddTransient<LoginViewModel>().AddTransient<LoginPage>();
            builder.Services.AddTransient<RegisterViewModel>().AddTransient<RegisterPage>();
            builder.Services.AddSingleton<MainViewModel>().AddSingleton<MainPage>();
            builder.Services.AddSingleton<AllTasksViewModel>().AddSingleton<AllTasksPage>();
            builder.Services.AddTransient<SettingsViewModel>().AddTransient<SettingsPage>();
            builder.Services.AddTransient<AddTaskViewModel>().AddTransient<AddTaskPage>();
            builder.Services.AddTransient<TaskDetailsViewModel>().AddTransient<TaskDetailsPage>();
            builder.Services.AddTransient<EditTaskViewModel>().AddTransient<EditTaskPage>();

            ConfigureRefit(builder.Services);
            return builder.Build();
        }

        private static void ConfigureRefit(IServiceCollection services)
        {
            const string ApiBaseUrl = "https://9l8jdsvp-7241.euw.devtunnels.ms";

            services.AddRefitClient<IAuthApi>()
                .ConfigureHttpClient(SetHttpClient);

            services.AddRefitClient<ITaskApi>(GetRefitSetting)
                .ConfigureHttpClient(SetHttpClient);

            services.AddRefitClient<IProfileApi>(GetRefitSetting)
                .ConfigureHttpClient(SetHttpClient);

            static void SetHttpClient(HttpClient httpClient) =>             
                httpClient.BaseAddress = new Uri(ApiBaseUrl);

            static RefitSettings GetRefitSetting(IServiceProvider serviceProvider)
            {
                return new RefitSettings
                {
                    AuthorizationHeaderValueGetter = (_, __) => Task.FromResult("JWT")

                };
                
            }
            
        }
    }
}

    
