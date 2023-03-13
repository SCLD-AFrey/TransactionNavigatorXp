using System;
using DevExpress.Data.Browsing;
using Microsoft.Extensions.Logging;

namespace ClientGuiApp.ViewModels.MainApplication;

public class AccountsViewModel : ViewModelBase
{
    private readonly ILogger<AccountsViewModel> m_logger;
    private readonly IServiceProvider m_serviceProvider;

    public AccountsViewModel(ILogger<AccountsViewModel> p_logger)
    {
        m_logger = p_logger;
    }
}