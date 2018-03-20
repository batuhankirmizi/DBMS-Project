using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace DBMS.Controllers
{
    public abstract class Controller : IDBConnector
    {
        private SQLiteCommand command;
        public SQLiteCommand Command { get => command; set => command = value; }

        private SQLiteDataReader reader;
        public SQLiteDataReader Reader { get => reader; set => reader = value; }

        protected SQLiteConnection dbConnection;

        protected string connectionString = "";

        public Controller() { }

        public virtual void Connect(string databaseName)
        {
            if(!DatabaseExists(databaseName)) {
                MessageBox.Show("Database Connection Error! " + databaseName + " cannot be found.");
            } else {
                connectionString = "Data Source=" + SDBStatics.DB_PATH + databaseName + ";version=3;";
                dbConnection = new SQLiteConnection(connectionString);

                dbConnection.Open();
            }
        }

        /// <summary>
        /// Executes the given SQL Query
        /// </summary>
        /// <param name="query"> query string to be executed </param>
        /// <returns> return a reader instance to read the data </returns>
        protected virtual SQLiteDataReader ExecuteQuery(string query)
        {
            command = new SQLiteCommand(commandText: query, connection: dbConnection);
            if(command != null)
                return command.ExecuteReader();
            return null;
        }

        /// <summary>
        /// First method to be executed with user interaction. Validator for for some forms
        /// </summary>
        /// <returns> true if the data is validated </returns>
        public abstract bool Control();

        protected virtual bool DatabaseExists(string databaseName) => File.Exists(path: SDBStatics.DB_PATH + databaseName);

        public void Disconnect() => dbConnection.Close();
    }
}
