namespace DBMS.Controllers
{
    public class LoginController : Controller
    {
        private string connectorString;

        public LoginController(string connectorString)
        {
            this.connectorString = connectorString;
        }

        public override void Control()
        {
            Connect(connectorString);
        }
    }
}