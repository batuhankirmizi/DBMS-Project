using DBMS.Controllers.Interfaces;
using System;

namespace DBMS.Controllers
{
    public class MainPageController : Controller, ISessionEnder
    {
        public override bool Control()
        {
            Disconnect();

            Connect(SDBStatics.MAIN_DB);

            return connection != null;
        }

        public void Logout()
        {
            SSession.End();
        }

        public int GetMemberCount()
        {
            using(Reader = ExecuteQuery(SDBQueries.MAIN_GET_MEMBER_COUNT))
            {
                int toReturn = 0;
                while (Reader.Read())
                {
                    toReturn = Int32.Parse(Reader["c"].ToString());
                }

                Reader.Close();

                return toReturn;
            }
        }

        internal int GetUnpaidPaymentCount()
        {
            using (Reader = ExecuteQuery(SDBQueries.MAIN_GET_UNPAID_PAYMENT_COUNT))
            {
                int toReturn = 0;
                while (Reader.Read())
                {
                    toReturn = Int32.Parse(Reader["c"].ToString());
                }

                return toReturn;
            }
        }

        internal int GetFacilityCount()
        {
            using (Reader = ExecuteQuery(SDBQueries.MAIN_GET_FACILITY_COUNT))
            {
                int toReturn = 0;
                while (Reader.Read())
                {
                    toReturn = Int32.Parse(Reader["c"].ToString());
                }

                return toReturn;
            }
        }

        internal int GetEmployeeCount()
        {
            using(Reader = ExecuteQuery(SDBQueries.MAIN_GET_EMPLOYEE_COUNT))
            {
                int toReturn = 0;
                while (Reader.Read())
                {
                    toReturn = Int32.Parse(Reader["c"].ToString());
                }

                return toReturn;
            }
        }

        internal int GetCourseCount()
        {
            using (Reader = ExecuteQuery(SDBQueries.MAIN_GET_COURSE_COUNT))
            {
                int toReturn = 0;
                while (Reader.Read())
                {
                    toReturn = Int32.Parse(Reader["c"].ToString());
                }

                return toReturn;
            }
        }

        internal int GetMembershipsAboutToFinish()
        {
            using (Reader = ExecuteQuery(SDBQueries.MAIN_GET_MEMBERSHIPS_ABOUT_TO_EXPIRE))
            {
                int toReturn = 0;
                while (Reader.Read())
                {
                    toReturn = Int32.Parse(Reader["c"].ToString());
                }

                return toReturn;
            }
        }

        internal int GetEquipmentCount()
        {
            using (Reader = ExecuteQuery(SDBQueries.MAIN_GET_EQUIPMENT_COUNT))
            {
                int toReturn = 0;
                while (Reader.Read())
                {
                    toReturn = Int32.Parse(Reader["c"].ToString());
                }

                return toReturn;
            }
        }

        internal int GetOutOfWarrantyEquipmentCount()
        {
            using (Reader = ExecuteQuery(SDBQueries.MAIN_GET_OUT_OF_WARRANTY_EQUIPMENT))
            {
                int toReturn = 0;
                while (Reader.Read())
                {
                    toReturn = Int32.Parse(Reader["c"].ToString());
                }

                return toReturn;
            }
        }
    }
}
