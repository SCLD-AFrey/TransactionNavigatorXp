﻿using Microsoft.Extensions.Logging;

namespace ClientGuiApp.ViewModels.MainApplication;

public class SettingsViewModel : ViewModelBase
{
    private readonly ILogger<SettingsViewModel> m_logger;

    public SettingsViewModel(ILogger<SettingsViewModel> p_logger)
    {
        m_logger = p_logger;
    }
}