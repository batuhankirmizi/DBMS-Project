using System.Timers;

namespace DBMS.Controllers
{
    public static class SSession
    {
        public static string username = "";
        public static string name = "";
        public static bool isManager = false;

        private static Timer timer = new Timer();
        
        public static void Start(string username_, string name_, bool isManager_)
        {
            username = username_;
            name = name_;
            isManager = isManager_;

            timer.Start();
        }

        public static void End()
        {
            username = "";
            name = "";
            isManager = false;

            timer.Stop();
        }

        public static string GetElapsedTime()
        {
            return timer.ToString();
        }
    }
}
