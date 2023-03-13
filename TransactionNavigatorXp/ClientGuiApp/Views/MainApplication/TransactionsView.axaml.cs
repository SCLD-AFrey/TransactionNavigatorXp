using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ClientGuiApp.ViewModels.MainApplication;

namespace ClientGuiApp.Views.MainApplication;

public partial class TransactionsView : UserControl
{
#pragma warning disable CS8618
    public TransactionsView() { }
#pragma warning restore CS8618
    public TransactionsView(TransactionsViewModel p_viewModel)
    {
        InitializeComponent();
        DataContext = p_viewModel;
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}