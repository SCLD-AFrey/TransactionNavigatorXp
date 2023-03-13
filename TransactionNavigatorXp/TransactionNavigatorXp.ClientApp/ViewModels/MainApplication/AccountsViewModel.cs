using Microsoft.Extensions.Logging;

namespace TransactionNavigatorXp.ClientApp.ViewModels.MainApplication;

public class AccountsViewModel : ViewModelBase
{
    private readonly ILogger<AccountsViewModel> m_logger;

    public AccountsViewModel(ILogger<AccountsViewModel> p_logger)
    {
        m_logger = p_logger;

    }
}