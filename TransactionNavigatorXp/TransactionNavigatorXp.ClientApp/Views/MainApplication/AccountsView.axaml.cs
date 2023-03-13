using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Microsoft.Extensions.Logging;
using TransactionNavigatorXp.ClientApp.ViewModels.MainApplication;

namespace TransactionNavigatorXp.ClientApp.Views.MainApplication;

public partial class AccountsView : UserControl
{
    private readonly ILogger<AccountsView> m_logger;

#pragma warning disable CS8618
    public AccountsView()
    {
    }
#pragma warning restore CS8618
    public AccountsView(ILogger<AccountsView> p_logger, AccountsViewModel p_viewModel)
    {
        m_logger = p_logger;
        m_logger.LogDebug("Creating AccountsView");
        InitializeComponent();
        DataContext = p_viewModel;
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}