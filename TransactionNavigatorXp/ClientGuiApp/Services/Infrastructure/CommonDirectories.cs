using System;
using System.IO;
using Microsoft.Extensions.Logging;

namespace ClientGuiApp.Services.Infrastructure;

public class CommonDirectories
{
    private readonly ILogger<CommonDirectories> m_logger;

    public CommonDirectories(ILogger<CommonDirectories> p_logger)
    {
        m_logger = p_logger;
        CreateFolders();
    }

    public string m_appDataPath =
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), ".TransactionNavigatorXp");

    private void CreateFolders()
    {
        var newDirectory = Directory.CreateDirectory(m_appDataPath);
    }
}