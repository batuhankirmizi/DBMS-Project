using DBMS.Controllers.Interfaces;

namespace DBMS.Controllers
{
    public class MainPageController : Controller, ISessionEnder
    {
        public override bool Control()
        {
            throw new System.NotImplementedException();
        }

        public void Logout()
        {
            SSession.End();
        }
    }
}
