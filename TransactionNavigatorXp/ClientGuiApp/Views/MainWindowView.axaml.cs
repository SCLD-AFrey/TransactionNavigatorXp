using System.Reactive;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace ClientGuiApp.Views;

public partial class MainWindowView : Window
{
    public MainWindowView()
    {
        InitializeComponent();
        DataContext = this;
        m_carousel = this.FindControl<Carousel>("MainCarousel")!;
        DoNavigation = ReactiveCommand.Create<string>(Navigate);
    }

    public ReactiveCommand<string, Unit> DoNavigation { get; }
    [Reactive] private Carousel m_carousel { get; set; }
    

    private void Navigate(string p_page)
    {
        m_carousel.SelectedIndex = p_page switch
        {
            "main" => 0,
            "transactions" => 1,
            "accounts" => 2,
            "settings" => 3,
            _ => m_carousel.SelectedIndex
        };
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}