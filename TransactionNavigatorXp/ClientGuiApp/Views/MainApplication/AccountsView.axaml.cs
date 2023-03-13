using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ClientGuiApp.ViewModels.MainApplication;
using Microsoft.Extensions.DependencyInjection;

namespace ClientGuiApp.Views.MainApplication;

public partial class AccountsView : UserControl
{
#pragma warning disable CS8618
    public AccountsView() { }
#pragma warning restore CS8618
    public AccountsView(AccountsViewModel p_viewModel)
    {
        InitializeComponent();
        DataContext = p_viewModel;
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}