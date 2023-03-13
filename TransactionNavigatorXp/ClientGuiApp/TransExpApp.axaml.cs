using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using ClientGuiApp.Services.Database;
using ClientGuiApp.Services.Infrastructure;
using ClientGuiApp.ViewModels;
using ClientGuiApp.ViewModels.MainApplication;
using ClientGuiApp.Views;
using ClientGuiApp.Views.MainApplication;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;

namespace ClientGuiApp;

public partial class TransExpApp : Application
{
    public readonly IHost m_appHost;
    public static int CurrentUserId { get; set; } = 1;
    public TransExpApp()
    {
        m_appHost = Host.CreateDefaultBuilder()
            .ConfigureLogging(p_options =>
            {
                p_options.AddDebug();
                p_options.AddSerilog();
            })
            .ConfigureServices(ConfigureServices).Build();
    }
    private void ConfigureServices(IServiceCollection p_services)
    {
        p_services.AddSingleton<CommonDirectories>();
        p_services.AddSingleton<CommonFiles>();
        p_services.AddSingleton<DatabaseUtilities>();
        
        p_services.AddSingleton<TransactionDatabaseInterface>();
        p_services.AddSingleton<TransactionDatabaseInitialization>();

        p_services.AddSingleton<MainWindowView>();
        p_services.AddSingleton<MainWindowViewModel>();

        p_services.AddSingleton<LoginWindowView>();
        p_services.AddSingleton<LoginWindowViewModel>();

        p_services.AddSingleton<AccountsView>();
        p_services.AddSingleton<AccountsViewModel>();

        p_services.AddSingleton<MainView>();
        p_services.AddSingleton<MainViewModel>();

        p_services.AddSingleton<SettingsView>();
        p_services.AddSingleton<SettingsViewModel>();

        p_services.AddSingleton<TransactionsView>();
        p_services.AddSingleton<TransactionsViewModel>();



    }
    
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            if (CurrentUserId == 0)
            {
                desktop.MainWindow = m_appHost.Services.GetService<LoginWindowView>();
            }
            else
            {
                desktop.MainWindow = m_appHost.Services.GetService<MainWindowView>();
            }
        }

        base.OnFrameworkInitializationCompleted();
    }
}