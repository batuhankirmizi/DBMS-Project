using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DBMS.Controllers.DB;

namespace DBMS.Controllers
{
    class FacilitiesController : Controller
    {
        public override bool Control()
        {
            Connect(SDBStatics.MAIN_DB);

            return connection != null;
        }

        public bool HasFacilities()
        {
            int i = 0;
            using(Reader = ExecuteQuery(SDBQueries.FACILITIES_GET_FACILITIES))
            {
                while (Reader.Read())
                {
                    i++;
                    break;
                }

                Reader.Close();
            }

            return i > 0;
        }

        internal LinkedList<string> GetFacilities()
        {
            LinkedList<string> toReturn = new LinkedList<string>();
            
            using(Reader = ExecuteQuery(SDBQueries.FACILITIES_GET_FACILITIES))
            {
                while (Reader.Read())
                    toReturn.AddLast(Reader["id"].ToString() + " - " + Reader["name"].ToString());

                Reader.Close();
            }

            return toReturn;
        }

        internal void AddFacility(Facility facility)
        {
            string query = SDBQueries.FACILITIES_ADD_FACILTIY + GetPermissionId(facility.Permission) + "', '" + facility.Name + "');";
            using(Reader = ExecuteQuery(query))
                Reader.Close();
        }

        public void AddPermission(int accessLevel)
        {
            string query = SDBQueries.FACILITIES_ADD_PERMISSION + accessLevel + "');";
            using(Reader = ExecuteQuery(query))
                Reader.Close();
        }

        internal int GetPermissionId(int accessLevel)
        {
            int i = 0;
            using(Reader = ExecuteQuery(SDBQueries.FACILITIES_GET_PERMISSION_ID + accessLevel + "'"))
            {
                while(Reader.Read())
                    i = Int32.Parse(Reader["id"].ToString());

                Reader.Close();
            }

            return i;
        }

        internal int GetPermission(string name)
        {
            int i = 0;

            string query = SDBQueries.FACILITIES_GET_PERMISSION + name + "'";
            using(Reader = ExecuteQuery(query))
            {
                while(Reader.Read())
                    i = Int32.Parse(Reader["facility_access_level"].ToString());

                Reader.Close();
            }

            return i;
        }

        internal Facility GetFacility(string name)
        {
            Facility facility = null;

            int accessLevel = GetPermission(name);

            string query = SDBQueries.FACILITIES_GET_FACILITY + name + "'";
            using(Reader = ExecuteQuery(query))
            {
                while (Reader.Read())
                    facility = new Facility(accessLevel, Reader["name"].ToString());

                Reader.Close();
            }

            return facility;
        }

        internal void ChangeFacility(Facility currentFacility, Facility newFacility)
        {
            using(Reader = ExecuteQuery(SDBQueries.FACILITIES_CHANGE_FACILITY + " name = '" + newFacility.Name + "' WHERE name = '" + currentFacility.Name + "'"))
            {
                Reader.Close();
            }
        }
    }
}
