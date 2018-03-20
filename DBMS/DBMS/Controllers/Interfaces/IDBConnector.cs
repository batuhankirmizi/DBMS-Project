namespace DBMS.Controllers
{
    public interface IDBConnector
    {
        /// <summary>
        /// Connects the specified database name
        /// </summary>
        /// <param name="databaseName"> Name of the database </param>
        void Connect(string databaseName);

        /// <summary>
        /// Disconnects from the connected database
        /// </summary>
        void Disconnect();
    }
}