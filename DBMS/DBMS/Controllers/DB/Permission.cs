using System;

namespace DBMS.Controllers.DB
{
    public class Permission
    {
        private int facility_access_level;

        public Permission(int facility_access_level)
        {
            this.facility_access_level = facility_access_level;
        }

        public int Facility_access_level { get => facility_access_level; }
    }
}
