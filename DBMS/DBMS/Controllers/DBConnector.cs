namespace DBMS.Controllers
{
    public interface IDBConnector
    {
        void Connect(string databaseName);
    }
}