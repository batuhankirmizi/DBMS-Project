using System.Windows.Forms;
using System.Configuration;
using System.Data.Common;
using DBMS.Controllers.Interfaces;

namespace DBMS.Controllers
{
    public abstract class Controller : IDBConnector, IDBLogger
    {
        private DbProviderFactory factory = DbProviderFactories.GetFactory(ConfigurationManager.AppSettings["provider"]);

        private DbDataReader reader;
        public DbDataReader Reader { get => reader; set => reader = value; }

        protected DbConnection connection;

        protected string connectionString = "";

        public Controller() { }

        public virtual void Connect(string databaseName)
        {
            if (!DatabaseExists(databaseName))
            {
                MessageBox.Show("Database Connection Error! " + databaseName + " cannot be found.");
            } else {
                string connectionString = "Data Source=BATU-PC;Initial Catalog=" + databaseName + ";Integrated Security=True;Pooling=False";

                connection = factory.CreateConnection();
                connection.ConnectionString = connectionString;

                connection.Open();
            }
        }

        // TODO:
        /// <summary>
        /// Executes the given SQL Query
        /// </summary>
        /// <param name="query"> query string to be executed </param>
        /// <returns> return a reader instance to read the data </returns>
        protected virtual DbDataReader ExecuteQuery(string query)
        {
            DbCommand command = factory.CreateCommand();
            command.Connection = connection;
            command.CommandText = query;

            if (command != null)
                return command.ExecuteReader();
            return null;
        }

        /// <summary>
        /// First method to be executed with user interaction. Validator for for some forms
        /// </summary>
        /// <returns> true if the data is validated </returns>
        public abstract bool Control();

        protected virtual bool DatabaseExists(string databaseName) => true;

        public void Disconnect()
        {
           connection.Close();
        }

        public void Log(int admin_id, string username, string logDetails)
        {
            ExecuteQuery(SDBQueries.LOGIN_HISTORY_QUERY + admin_id + "', '" + username + "', '" + logDetails + "')");
        }

        public void FailLog(string username, string logDetails)
        {
            ExecuteQuery(SDBQueries.LOGIN_HISTORY_QUERY_FAILED + username + "', '" + logDetails + "')");
        }
    }
}
