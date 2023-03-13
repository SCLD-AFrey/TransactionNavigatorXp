using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ClientGuiApp.ViewModels.MainApplication;

namespace ClientGuiApp.Views.MainApplication;

public partial class MainView : UserControl
{
#pragma warning disable CS8618
    public MainView() { }
#pragma warning restore CS8618
    public MainView(MainViewModel p_viewModel)
    {
        InitializeComponent();
        DataContext = p_viewModel;
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}