﻿using Microsoft.Extensions.Logging;

namespace ClientGuiApp.ViewModels.MainApplication;

public class LoginViewModel : ViewModelBase
{
    private readonly ILogger<LoginViewModel> m_logger;

    public LoginViewModel(ILogger<LoginViewModel> p_logger)
    {
        m_logger = p_logger;
    }
    
}