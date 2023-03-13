using ClientGuiApp.Services.Infrastructure;
using DevExpress.Xpo;

namespace ClientGuiApp.Services.Database;

public class TransactionDatabaseInterface : IDatabaseInterface
{
    public TransactionDatabaseInterface(DatabaseUtilities p_utilities, CommonFiles p_requiredFolders)
    {
        DataLayer = p_utilities.GetDataLayer(p_requiredFolders.DatabasePath);
    }

    public IDataLayer DataLayer { get; }

    public UnitOfWork ProvisionUnitOfWork()
    {
        return new UnitOfWork(DataLayer);
    }
}