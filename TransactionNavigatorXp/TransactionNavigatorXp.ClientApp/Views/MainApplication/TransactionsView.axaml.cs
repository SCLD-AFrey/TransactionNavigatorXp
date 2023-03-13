using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Microsoft.Extensions.Logging;
using TransactionNavigatorXp.ClientApp.ViewModels.MainApplication;

namespace TransactionNavigatorXp.ClientApp.Views.MainApplication;

public partial class TransactionsView : UserControl
{
    private readonly ILogger<TransactionsView> m_logger;
#pragma warning disable CS8618
    public TransactionsView()
    {
    }
#pragma warning restore CS8618
    public TransactionsView(ILogger<TransactionsView> p_logger, TransactionsViewModel p_viewModel)
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