using System.Reactive;
using System.Threading.Tasks;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace ClientGuiApp.ViewModels;

public class LoginWindowViewModel : ViewModelBase
{
    public string WindowTitle { get; set; } = "Login Window View";

    public LoginWindowViewModel()
    {
        LoginCommand = ReactiveCommand.CreateFromTask(Login);
    }


    public ReactiveCommand<Unit, Unit> LoginCommand { get; }
    [Reactive] public string Username { get; set; }
    [Reactive] public string Password { get; set; }
    [Reactive] public string LoginMessage { get; set; } = string.Empty;
    private Task Login()
    {
        App.CurrentUserId = 1;
        return Task.CompletedTask;
    }
}