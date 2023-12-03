using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;
using UIBase.ViewModels;
using UIBase.Views;

namespace UIBase;

public sealed partial class App : Application
{
    public App()
    {
        Services = ConfigureServices();
        Startup += App_Startup;
    }

    private void App_Startup(object sender, StartupEventArgs e)
    {
        var mainWindow = Services.GetRequiredService<MainView>();
        mainWindow.Show();
    }

    /// <summary>
    /// Gets the current <see cref="App"/> instance in use
    /// </summary>
    public new static App Current => (App)Application.Current;

    /// <summary>
    /// Gets the <see cref="IServiceProvider"/> instance to resolve application services.
    /// </summary>
    public IServiceProvider Services { get; }

    /// <summary>
    /// Configures the services for the application.
    /// </summary>
    private static IServiceProvider ConfigureServices()
    {
        var services = new ServiceCollection();

        //services.AddSingleton<IFilesService, FilesService>();
        //services.AddSingleton<ISettingsService, SettingsService>();
        //services.AddSingleton<IClipboardService, ClipboardService>();
        //services.AddSingleton<IShareService, ShareService>();
        //services.AddSingleton<IEmailService, EmailService>();

        // Views
        services.AddSingleton<MainView>();

        // ViewModels
        services.AddTransient<MainViewModel>();
        services.AddTransient<LoginControlViewModel>();
        services.AddTransient<SignUpControlVIewModel>();
        services.AddTransient<ChangePasswordControlVIewModel>();

        return services.BuildServiceProvider();
    }
}

