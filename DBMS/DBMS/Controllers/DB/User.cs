namespace DBMS.Controllers.DB
{
    public class User
    {
        private string id;
        private string username;
        private string password;
        private string name;
        private bool is_manager;

        public User(string id, string username, string password, string name, int is_manager)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.name = name;
            this.is_manager = is_manager == 1;
        }

        public string Name { get => name; }
        public string Password { get => password; }
        public string Username { get => username; }
        public string Id { get => id; }
        public bool Is_manager { get => is_manager; set => is_manager = value; }
    }
}
