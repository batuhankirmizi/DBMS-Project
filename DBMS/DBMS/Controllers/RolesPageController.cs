using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DBMS.Controllers.DB;

namespace DBMS.Controllers
{
    class RolesPageController : Controller
    {
        public override bool Control()
        {
            Connect(SDBStatics.MAIN_DB);

            return connection != null;
        }

        internal bool HasRoles()
        {
            using(Reader = ExecuteQuery(SDBQueries.ROLES_GET_ALL_ROLES))
            {
                while(Reader.Read())
                {
                    Reader.Close();
                    return true;
                }

                Reader.Close();
                return false;
            }
        }

        internal LinkedList<string> GetRolesCombo()
        {
            LinkedList<string> toReturn = new LinkedList<string>();

            using(Reader = ExecuteQuery(SDBQueries.ROLES_GET_ALL_ROLES))
            {
                while (Reader.Read())
                {
                    toReturn.AddLast(Reader["id"].ToString() + " - " + Reader["role_name"].ToString());
                }

                Reader.Close();
            }

            return toReturn;
        }

        internal int GetPermissionId(int permission)
        {
            int toReturn = 0;
            using(Reader = ExecuteQuery(SDBQueries.ROLES_GET_PERMISSION_ID + permission))
            {
                while (Reader.Read())
                {
                    toReturn = int.Parse(Reader["id"].ToString());
                }

                Reader.Close();
            }

            return toReturn;
        }

        internal int GetPermission(int permissionId)
        {
            int toReturn = 0;
            using(Reader = ExecuteQuery(SDBQueries.ROLES_GET_PERMISSION + permissionId))
            {
                while(Reader.Read())
                    toReturn = int.Parse(Reader["facility_access_level"].ToString());

                Reader.Close();
            }

            return toReturn;
        }

        internal void AddRole(Role currentRole)
        {
            string query = SDBQueries.ROLES_ADD_ROLE + currentRole.PermissionId + "', '" + currentRole.RoleName + "');";
            using(Reader = ExecuteQuery(query))
            {
                Reader.Close();
            }
        }

        internal Role GetRole(int roleId)
        {
            Role role = null;
            using (Reader = ExecuteQuery(SDBQueries.ROLES_GET_ROLE + roleId))
            {
                while (Reader.Read())
                    role = new Role(int.Parse(Reader["permission_id"].ToString()), Reader["role_name"].ToString());
            }

            return role;
        }

        private int GetRoleId(Role role)
        {
            int toReturn = 0;
            using(Reader = ExecuteQuery(SDBQueries.ROLES_GET_ROLE_ID + role.RoleName + "'"))
            {
                while (Reader.Read())
                {
                    toReturn = int.Parse(Reader["id"].ToString());
                }

                Reader.Close();
            }

            return toReturn;
        }

        internal void Change(Role currentRole, Role newRole)
        {
            string query = SDBQueries.ROLES_CHANGE_ROLE;
            string diff = currentRole.GetDifferences(newRole);

            if(diff.Contains("permission_id"))
                query += "permission_id = '" + newRole.PermissionId + "', ";
            if(diff.Contains("role_name"))
                query += "role_name = '" + newRole.RoleName + "', ";

            query = query.Substring(0, query.Length - 2) + " WHERE id = " + GetRoleId(currentRole);
            using(Reader = ExecuteQuery(query))
            {
                Reader.Close();
            }
        }
    }
}
