using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Microsoft.Extensions.Logging;
using TransactionNavigatorXp.ClientApp.ViewModels.MainApplication;

namespace TransactionNavigatorXp.ClientApp.Views.MainApplication;

public partial class MainView : UserControl
{
    private readonly ILogger<MainView> m_logger;
#pragma warning disable CS8618
    public MainView()
    {
    }
#pragma warning restore CS8618
    public MainView(ILogger<MainView> p_logger, MainViewModel p_viewModel)
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