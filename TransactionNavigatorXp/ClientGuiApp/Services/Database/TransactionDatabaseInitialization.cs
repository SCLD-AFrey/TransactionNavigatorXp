using System.Data;
using System.IO;
using System.Threading.Tasks;
using ClientGuiApp.Services.Infrastructure;
using Microsoft.Extensions.Logging;


// ReSharper disable UnusedVariable

namespace ClientGuiApp.Services.Database;

public class TransactionDatabaseInitialization
{
    private readonly ILogger<TransactionDatabaseInitialization> m_logger;
    private readonly TransactionDatabaseInterface m_dbInterface;
    private readonly CommonFiles m_requiredFilesService;
    private readonly PasswordHash m_passwordHash;

    public TransactionDatabaseInitialization(ILogger<TransactionDatabaseInitialization> p_logger,
        TransactionDatabaseInterface p_dbInterface, CommonFiles p_requiredFilesService, PasswordHash p_passwordHash)
    {
        m_logger = p_logger;
        m_dbInterface = p_dbInterface;
        m_requiredFilesService = p_requiredFilesService;
        m_passwordHash = p_passwordHash;
    }

    public bool IsFirstRun { get; set; }

    public async Task DoFirstTimeSetup()
    {
        m_logger.LogDebug("Checking if database data exists");

        using var unitOfWork = m_dbInterface.ProvisionUnitOfWork();

        if (File.Exists(m_requiredFilesService.DatabasePath))
        {
            var fileInfo = new FileInfo(m_requiredFilesService.DatabasePath);

            if (fileInfo.Length == 0)
            {
                IsFirstRun = true;

                m_logger.LogDebug("Database does not exist, creating initial groups");

                //TODO add init

                // var admin = new User(unitOfWork)
                // {
                //     UserName = "admin", Password = m_passwordHash.GeneratePasswordHash("password", out var salt1), Salt = salt1
                // };
                //
                // var afrey = new User(unitOfWork)
                // {
                //     UserName = "afrey", Password = m_passwordHash.GeneratePasswordHash("password", out var salt2), Salt = salt2
                // };
                //
                // foreach (var v in new []{"Cash","Credit","Check","E-Payment","Other"})
                // {
                //     new TransType(unitOfWork) { Title = v };
                // }


                await unitOfWork.CommitChangesAsync();

                return;
            }

            IsFirstRun = true;
        }
        else
        {
            throw new DataException("Database file does not exist but should at this point in program execution");
        }
    }
}