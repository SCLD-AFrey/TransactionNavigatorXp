using Microsoft.Extensions.Logging;

namespace ClientGuiApp.ViewModels.MainApplication;

public class TransactionsViewModel : ViewModelBase
{
    private readonly ILogger<TransactionsViewModel> m_logger;

    public TransactionsViewModel(ILogger<TransactionsViewModel> p_logger)
    {
        m_logger = p_logger;
    }
}
