using System;
using System.Diagnostics;

namespace DBMS.Controllers
{
    public static class SSession
    {
        public static string username = "";
        public static string name = "";
        public static bool isManager = false;

        private static Stopwatch stopWatch = new Stopwatch();
        

        public static void Start(string username_, string name_, bool isManager_)
        {
            username = username_;
            name = name_;
            isManager = isManager_;

            stopWatch.Start();
        }

        public static void End()
        {
            username = "";
            name = "";
            isManager = false;

            stopWatch.Reset();

            stopWatch.Stop();
        }

        public static string GetElapsedTime()
        {
            return String.Format("{0:00}:{1:00}:{2:00}", stopWatch.Elapsed.Hours, stopWatch.Elapsed.Minutes, stopWatch.Elapsed.Seconds);
        }
    }
}
