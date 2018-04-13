using DBMS.Controllers.DB;
using System;

namespace DBMS.Controllers
{
    public class LoginController : Controller, IDBValidator
    {
        private User user;
        public User User { get => user; }

        private string username;
        public string Username { get => username; set => username = value; }

        private string password;
        public string Password { get => password; set => password = value; }

        private const string dbName = SDBStatics.LOGIN_DB;

        public LoginController() { }

        public LoginController(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public override bool Control()
        {
            Connect(dbName);

            return Validate(username, password);
        }

        public override void Connect(string databaseName)
        {
            base.Connect(databaseName);
        }

        public bool Validate(string username, string password)
        {
            using(Reader = base.ExecuteQuery(SDBQueries.LOGIN_QUERY))
            {
                while (Reader.Read())
                {
                    if (Reader["username"].ToString().Equals(username) && Reader["password"].ToString().Equals(password))
                    {
                        user = new User(Reader["id"].ToString(), Reader["username"].ToString(), Reader["password"].ToString(), Reader["name"].ToString(), Boolean.Parse(Reader["is_manager"].ToString()));

                        Login(user.Username, user.Name, user.Is_manager);

                        Reader.Close();

                        Log(Int32.Parse(user.Id), user.Username, "Log In Successful on " + DateTime.UtcNow.Date.ToString("dd/MM/yyyy") + " at " + DateTime.Now.ToString("h:mm:ss tt"));

                        return true;
                    }
                }

                Reader.Close();
            }

            FailLog(username, "Log In failed on " + DateTime.UtcNow.Date.ToString("dd/MM/yyyy") + " at " + DateTime.Now.ToString("h:mm:ss tt"));

            return false;
        }

        public void Login(string username, string name, bool is_manager)
        {
            SSession.Start(username, name, is_manager);
        }
    }
}
