namespace DBMS.Controllers.DB
{
    public class User
    {
        private string id;
        private string username;
        private string password;
        private string name;

        public User(string id, string username, string password, string name)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.name = name;
        }

        public string Name { get => name; }
        public string Password { get => password; }
        public string Username { get => username; }
        public string Id { get => id; }
    }
}
