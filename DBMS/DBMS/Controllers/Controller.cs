using System;
using System.Data.OleDb;
using System.Configuration;

namespace DBMS.Controllers
{
    public abstract class Controller : IDBConnector
    {
        public Controller() { }

        public void Connect(string databaseName)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings[databaseName].ToString();
            connection.Open();

            Console.WriteLine("Connection Success"); // TODO: Debug code
        }

        public abstract void Control();
    }
}
