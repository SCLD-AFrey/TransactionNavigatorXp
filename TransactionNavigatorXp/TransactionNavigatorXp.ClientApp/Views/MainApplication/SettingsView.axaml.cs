using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Microsoft.Extensions.Logging;
using TransactionNavigatorXp.ClientApp.ViewModels.MainApplication;

namespace TransactionNavigatorXp.ClientApp.Views.MainApplication;

public partial class SettingsView : UserControl
{
    private readonly ILogger<SettingsView> m_logger;
#pragma warning disable CS8618
    public SettingsView()
    {
    }
#pragma warning restore CS8618
    public SettingsView(ILogger<SettingsView> p_logger, SettingsViewModel p_viewModel)
    {
        m_logger = p_logger;
        InitializeComponent();
        DataContext = p_viewModel;
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}