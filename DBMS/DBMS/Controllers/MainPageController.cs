using DBMS.Controllers.Interfaces;

namespace DBMS.Controllers
{
    public class MainPageController : Controller, ISessionEnder
    {
        public override bool Control()
        {
            Disconnect();
            return connection == null;
        }

        public void Logout()
        {
            SSession.End();
        }
    }
}
