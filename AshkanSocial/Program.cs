using AshkanSocial.Application.Common.Session;
using AshkanSocial.Application.Features.Auth.Login;
using AshkanSocial.Application.Validators;
using AshkanSocial.Forms.Auth;
using AshkanSocial.Infrastructure.DependencyInjection;
using AshkanSocial.Localization;
using AshkanSocial.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AshkanSocial;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        LanguageService.Initialize();

        ApplicationConfiguration.Initialize();

        ServiceProvider serviceProvider = ConfigureServices();

        System.Windows.Forms.Application.Run(
            serviceProvider.GetRequiredService<RegisterForm>());
    }

    private static ServiceProvider ConfigureServices()
    {
        IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile(
                path: "appsettings.json",
                optional: false,
                reloadOnChange: false)
            .Build();

        ServiceCollection services = new();

        // DbContext و IUserService
        services.AddInfrastructure(configuration);

        // Validatorها
        services.AddTransient<RegisterUserRequestValidator>();
        services.AddTransient<LoginRequestValidator>();

        // وضعیت کاربر واردشده در مدت اجرای برنامه
        services.AddSingleton<CurrentUserSession>();

        // Navigation بین فرم‌ها
        services.AddSingleton<FormNavigationService>();

        // بسیار مهم: هر دو فرم باید پیش از BuildServiceProvider ثبت شوند.
        services.AddTransient<RegisterForm>();
        services.AddTransient<LoginForm>();
        services.AddTransient<MainForm>();

        return services.BuildServiceProvider();
    }
}
