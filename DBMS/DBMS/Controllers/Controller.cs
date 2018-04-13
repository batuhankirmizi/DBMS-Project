using System.Windows.Forms;
using System.Configuration;
using System.Data.Common;
using DBMS.Controllers.Interfaces;
using System;

namespace DBMS.Controllers
{
    public abstract class Controller : IDBConnector, IDBLogger
    {
        private DbProviderFactory factory = DbProviderFactories.GetFactory(ConfigurationManager.AppSettings["provider"]);

        private DbDataReader reader;
        protected DbDataReader Reader { get => reader; set => reader = value; }

        protected DbConnection connection;

        protected string connectionString = "";

        public Controller() { }

        /// <summary>
        /// Connects to the specified database
        /// </summary>
        /// <param name="databaseName">Name of the database</param>
        public virtual void Connect(string databaseName)
        {
            string connectionString = "Data Source=BATU-PC;Initial Catalog=" + databaseName + ";Integrated Security=True;Pooling=False";

            connection = factory.CreateConnection();
            connection.ConnectionString = connectionString;

            if(connection == null)
            {
                MessageBox.Show("Cannot connect to the datatabase: " + databaseName);
                return;
            }

            connection.Open();
        }

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

        public void Disconnect()
        {
            if(connection != null)
                connection.Close();
        }

        public void Log(int admin_id, string username, string logDetails)
        {
            using(reader = ExecuteQuery(SDBQueries.LOGIN_HISTORY_QUERY + admin_id + "', '" + username + "', '" + logDetails + "')"))
            {
                reader.Close();
            }
        }

        public void FailLog(string username, string logDetails)
        {
            ExecuteQuery(SDBQueries.LOGIN_HISTORY_QUERY_FAILED + username + "', '" + logDetails + "')");

            reader.Close();
        }
    }
}
