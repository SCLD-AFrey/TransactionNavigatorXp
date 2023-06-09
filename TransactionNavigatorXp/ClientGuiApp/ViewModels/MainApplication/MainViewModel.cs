﻿using Microsoft.Extensions.Logging;

namespace ClientGuiApp.ViewModels.MainApplication;

public class MainViewModel : ViewModelBase 
{
    private readonly ILogger<MainViewModel> m_logger;

    public MainViewModel(ILogger<MainViewModel> p_logger) 
    {
        m_logger = p_logger;
    }
}