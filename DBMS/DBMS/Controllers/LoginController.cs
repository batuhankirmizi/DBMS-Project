using DBMS.Controllers.DB;

namespace DBMS.Controllers
{
    public class LoginController : Controller, IDBValidator
    {
        private User user;
        public User User { get => user; }

        private string username = "", password = "";
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        private const string connectorString = SDBStatics.LOGIN_DB;

        public LoginController() { }

        public LoginController(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public override bool Control()
        {
            Connect(connectorString);

            return Validate(username, password);
        }

        public override void Connect(string databaseName) => base.Connect(databaseName);

        public bool Validate(string username, string password)
        {
            Reader = base.ExecuteQuery(SDBQueries.LOGIN_QUERY);
            while(Reader.Read())
                if(Reader["username"].Equals(username) && Reader["password"].Equals(password))
                {
                    user = new User(Reader["id"].ToString(), Reader["username"].ToString(), Reader["password"].ToString(), Reader["name"].ToString());
                    return true;
                }

            return false;
        }
    }
}