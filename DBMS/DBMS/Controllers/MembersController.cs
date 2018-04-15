using DBMS.Controllers.DB;
using DBMS.Controllers.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DBMS.Controllers
{
    public class MembersController : Controller, IDBConnector, ISessionEnder
    {
        public override bool Control()
        {
            Connect(SDBStatics.MAIN_DB);
            return connection != null;
        }

        public void Logout()
        {
            SSession.End();
        }

        public LinkedList<string> GetMembers()
        {
            using(Reader = ExecuteQuery(SDBQueries.MEMBER_GET_MEMBERS_QUERY))
            {
                LinkedList<string> toReturn = new LinkedList<string>();

                for (int i = 0; Reader.Read(); i++)
                    toReturn.AddLast(Reader["id"].ToString() + " - " + Reader["name"].ToString() + " " + Reader["surname"].ToString());

                Reader.Close();

                return toReturn;
            }
        }

        public Member GetMember(int id)
        {
            using(Reader = ExecuteQuery(SDBQueries.MEMBER_GET_MEMBER + id.ToString()))
            {
                Member toReturn = null;
                while (Reader.Read())
                {
                    toReturn = new Member(Int32.Parse(Reader["permission_id"].ToString()), Reader["name"].ToString(), Reader["surname"].ToString(), Char.Parse(Reader["gender"].ToString()),
                    Int32.Parse(Reader["age"].ToString()), Reader["email"].ToString(), Int64.Parse(Reader["phone_number"].ToString()), Reader["address"].ToString(),
                    DateTime.Parse(Reader["date_joined"].ToString()), DateTime.Parse(Reader["birth_date"].ToString()), Int32.Parse(Reader["payment_id"].ToString()),
                    Int32.Parse(Reader["height"].ToString()), Int32.Parse(Reader["weight"].ToString()), DateTime.Parse(Reader["membership_expiry_date"].ToString()),
                    Int32.Parse(Reader["weekly_entrance_right"].ToString()));
                }

                Reader.Close();

                return toReturn;
            }
        }

        public void AddPayment(Payment payment)
        {
            using(Reader = ExecuteQuery(SDBQueries.MEMBER_ADD_PAYMENT + payment.Amount + "', '" + payment.DueDate + "', '" + payment.Description.ToString() + "', '" + payment.IsPaid + "')"))
            {
                Reader.Close();
            }
        }

        public void AddMember(Member member)
        {
            string query = SDBQueries.MEMBER_ADD_MEMBER + member.Payment_id + "', '" + member.Permission_id + "', '" + member.Name + "', '" + member.Surname + "', '" +
                member.Gender + "', '" + member.Age + "', '" + member.Email + "', '" + member.PhoneNumber + "', '" + member.Address + "', '" + member.Height + "', '" +
                member.Weight + "', '" + member.BirthDate + "', '" + member.DateJoined + "', '" + member.MembershipExpiryDate + "', '" + member.WeeklyEntranceRight + "');";

            using(Reader = ExecuteQuery(query))
            {
                Reader.Close();
            }
        }

        public int GetMaxPaymentId()
        {
            using(Reader = ExecuteQuery(SDBQueries.MEMBER_PAYMENT_SELECT_MAX_ID))
            {
                int toReturn = 1;
                while (Reader.Read())
                {
                    toReturn = Int32.Parse(Reader["id"].ToString());
                }

                Reader.Close();

                return toReturn;
            }
        }

        private bool PermissionExists(int permissionLevel)
        {
            using (Reader = ExecuteQuery(SDBQueries.MEMBER_EXISTS_PERMISSION + permissionLevel.ToString()))
            {
                int toReturn = 0;
                while (Reader.Read())
                {
                    toReturn = Int32.Parse(Reader["c"].ToString());
                }

                Reader.Close();

                return toReturn >= 1;
            }
        }

        public int GetPermissionId(int permissionLevel)
        {
            if(!PermissionExists(permissionLevel))
                CreatePermission(permissionLevel);

            using(Reader = ExecuteQuery(SDBQueries.MEMBER_PERMISSION_GET_ID + permissionLevel.ToString()))
            {
                int toReturn = 1;
                while(Reader.Read())
                {
                    toReturn = Int32.Parse(Reader["id"].ToString());
                }

                Reader.Close();

                return toReturn;
            }
        }

        private void CreatePermission(int permissionLevel)
        {
            using (Reader = ExecuteQuery(SDBQueries.MEMBER_ADD_PERMISSION + permissionLevel.ToString() + "');"))
                Reader.Close();
        }

        internal int GetPermissionLevel(Member member)
        {
            using (Reader = ExecuteQuery(SDBQueries.MEMBER_GET_PERMISSION + member.Permission_id.ToString()))
            {
                int toReturn = 1;
                while (Reader.Read())
                {
                    toReturn = Int32.Parse(Reader["facility_access_level"].ToString());
                }

                Reader.Close();

                return toReturn;
            }
        }

        internal int GetMonthlyPayment(Member member)
        {
            using (Reader = ExecuteQuery(SDBQueries.MEMBER_GET_PAYMENT + member.Payment_id.ToString()))
            {
                int toReturn = 1;
                while (Reader.Read())
                    toReturn = Int32.Parse(Reader["amount"].ToString());

                Reader.Close();

                return toReturn;
            }
        }

        internal void UpdateMember(Member oldMember, Member newMember)
        {
            LinkedList<string> diff = oldMember.GetDifferences(newMember);

            string query = "";
            LinkedListNode<string> iter = diff.First;
            while(iter != null)
            {
                if(iter != diff.First)
                    query += ", ";

                if(iter.Value.ToString().Equals("name"))
                    query += iter.Value.ToString() + " = '" + newMember.Name + "'";
                if (iter.Value.ToString().Equals("surname"))
                    query += iter.Value.ToString() + " = '" + newMember.Surname + "'";
                if (iter.Value.ToString().Equals("gender"))
                    query += iter.Value.ToString() + " = '" + newMember.Gender + "'";
                if (iter.Value.ToString().Equals("age"))
                    query += iter.Value.ToString() + " = '" + newMember.Age + "'";
                if (iter.Value.ToString().Equals("email"))
                    query += iter.Value.ToString() + " = '" + newMember.Email + "'";
                if (iter.Value.ToString().Equals("phone_number"))
                    query += iter.Value.ToString() + " = '" + newMember.PhoneNumber + "'";
                if (iter.Value.ToString().Equals("address"))
                    query += iter.Value.ToString() + " = '" + newMember.Address + "'";
                if (iter.Value.ToString().Equals("date_joined"))
                    query += iter.Value.ToString() + " = '" + newMember.DateJoined + "'";
                if (iter.Value.ToString().Equals("birth_date"))
                    query += iter.Value.ToString() + " = '" + newMember.BirthDate + "'";
                if (iter.Value.ToString().Equals("height"))
                    query += iter.Value.ToString() + " = '" + newMember.Height + "'";
                if (iter.Value.ToString().Equals("weight"))
                    query += iter.Value.ToString() + " = '" + newMember.Weight + "'";

                iter = iter.Next;
            }

            using (Reader = ExecuteQuery(SDBQueries.MEMBER_UPDATE_MEMBER + query + " WHERE id = " + GetMemberId(oldMember) + ";"))
                Reader.Close();
        }

        internal void DeleteMember(Member member)
        {
            using (Reader = ExecuteQuery(SDBQueries.MEMBER_DELETE_MEMBERSHIP + member.Payment_id.ToString()))
                Reader.Close();
            using (Reader = ExecuteQuery(SDBQueries.MEMBER_DELETE_MEMBER + GetMemberId(member).ToString()))
                Reader.Close();
            using (Reader = ExecuteQuery(SDBQueries.MEMBER_DELETE_PAYMENT + member.Payment_id.ToString()))
                Reader.Close();
        }

        private int GetMemberId(Member member)
        {
            using (Reader = ExecuteQuery(SDBQueries.MEMBER_GET_ID + member.Payment_id))
            {
                int toReturn = 1;
                while (Reader.Read())
                    toReturn = Int32.Parse(Reader["id"].ToString());

                Reader.Close();

                return toReturn;
            }
        }

        internal void AddMembership(Member member)
        {
            string query = SDBQueries.MEMBER_ADD_MEMBERSHIP + GetMemberId(member).ToString() + "', '" + member.Payment_id + "', '" + member.MembershipExpiryDate + "', '" +
                member.WeeklyEntranceRight + "');";

            using (Reader = ExecuteQuery(query))
            {
                Reader.Close();
            }
        }

        internal void AddMemberImprovement(Member member)
        {
            string query = SDBQueries.MEMBER_ADD_MEMBER_IMPROVEMENTS + GetMemberId(member) + "', '" + member.Weight + "', '" + member.Height + "', '" + member.DateJoined +"');";
            using(Reader = ExecuteQuery(query))
                Reader.Close();
        }
    }
}
