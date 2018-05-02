using System;
using System.Collections.Generic;
using DBMS.Controllers.DB;

namespace DBMS.Controllers
{
    class PermissionsController : Controller
    {
        public override bool Control()
        {
            Connect(SDBStatics.MAIN_DB);

            return connection != null;
        }

        internal LinkedList<string> GetPermissionsForComboBox()
        {
            LinkedList<string> toReturn = new LinkedList<string>();
            using(Reader = ExecuteQuery(SDBQueries.PERMISSIONS_GET_ALL_PERMS))
            {
                while(Reader.Read())
                    toReturn.AddLast(Reader["id"].ToString() + " - " + Reader["facility_access_level"].ToString());

                Reader.Close();
            }
            return toReturn;
        }

        internal Permission GetPermission(int permissionId)
        {
            Permission permission = null;
            using(Reader = ExecuteQuery(SDBQueries.PERMISSIONS_GET_PERM + permissionId))
            {
                while(Reader.Read())
                    permission = new Permission(Int32.Parse(Reader["facility_access_level"].ToString()));
                Reader.Close();
            }

            return permission;
        }

        internal void AddPermission(int facilityAccessLevel)
        {
            using(Reader = ExecuteQuery(SDBQueries.PERMISSIONS_ADD_PERM + facilityAccessLevel + "');"))
            {
                Reader.Close();
            }
        }

        internal bool HasPermission(int fal)
        {
            using(Reader = ExecuteQuery(SDBQueries.PERMISSIONS_GET_PERM_FAL + fal))
            {
                while(Reader.Read())
                    return true;
                Reader.Close();
                return false;
            }
        }
    }
}
