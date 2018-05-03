using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DBMS.Controllers.DB;

namespace DBMS.Controllers
{
    class EmployeesController : Controller
    {
        public override bool Control()
        {
            Connect(SDBStatics.MAIN_DB);

            return connection != null;
        }

        internal bool HasEmployees()
        {
            using(Reader = ExecuteQuery(SDBQueries.EMPLOYEES_GET_ALL_EMPS))
            {
                while (Reader.Read())
                {
                    Reader.Close();
                    return true;
                }

                Reader.Close();
                return false;
            }
        }

        internal LinkedList<string> GetEmployeesComboBox()
        {
            LinkedList<string> toReturn = new LinkedList<string>();
            using(Reader = ExecuteQuery(SDBQueries.EMPLOYEES_GET_EMPS_COMBO))
            {
                while (Reader.Read())
                {
                    toReturn.AddLast(Reader["id"].ToString() + " - " + Reader["name"].ToString() + " " + Reader["surname"].ToString());
                }

                Reader.Close();
            }

            return toReturn;
        }

        internal void DeleteEmployee(int employeeId)
        {
            using(Reader = ExecuteQuery(SDBQueries.EMPLOYEES_DELETE_EMPLOYEE + employeeId))
            {
                Reader.Close();
            }
        }

        internal void AddEmployee(Employee employee)
        {
            string query = SDBQueries.EMPLOYEES_ADD_EMPLOYEE + employee.RoleId + "', ' " + employee.Name + "', '" + employee.Surname + "', '" +
                employee.Gender + "', '" + employee.Age + "', '" + employee.Email + "', '" + employee.PhoneNumber + "', '" + employee.Address + "', '" + 
                employee.BirthDate + "', '" + employee.DateJoined + "');";

            using(Reader = ExecuteQuery(query))
            {
                Reader.Close();
            }
        }

        internal Employee GetEmployee(int employeeId)
        {
            Employee toReturn = null;
            using(Reader = ExecuteQuery(SDBQueries.EMPLOYEES_GET_EMP + employeeId))
            {
                while(Reader.Read())
                {
                    toReturn = new Employee(int.Parse(Reader["role_id"].ToString()), Reader["name"].ToString(), Reader["surname"].ToString(),
                        char.Parse(Reader["gender"].ToString()), int.Parse(Reader["age"].ToString()), Reader["email"].ToString(),
                        long.Parse(Reader["phone_number"].ToString()), Reader["address"].ToString(), DateTime.Parse(Reader["birth_date"].ToString()),
                        DateTime.Parse(Reader["date_joined"].ToString()));
                }
                Reader.Close();
            }

            return toReturn;
        }

        internal int GetRoleId(string roleName)
        {
            int toReturn = 0;
            using(Reader = ExecuteQuery(SDBQueries.EMPLOYEES_GET_ROLE_ID + roleName + "'"))
            {
                while (Reader.Read())
                    toReturn = int.Parse(Reader["id"].ToString());

                Reader.Close();
            }

            return toReturn;
        }

        internal string GetRoleName(int roleId)
        {
            string toReturn = "";
            using(Reader = ExecuteQuery(SDBQueries.EMPLOYEES_GET_ROLE_NAME + roleId + "'"))
            {
                while(Reader.Read())
                    toReturn = Reader["role_name"].ToString();

                Reader.Close();
            }

            return toReturn;
        }

        private int GetEmployeeId(Employee emp)
        {
            int toReturn = 0;
            using(Reader = ExecuteQuery(SDBQueries.EMPLOYEES_GET_EMP_ID + emp.PhoneNumber))
            {
                while(Reader.Read())
                    toReturn = int.Parse(Reader["id"].ToString());

                Reader.Close();
            }

            return toReturn;
        }

        internal void ChangeEmployee(Employee currentEmployee, Employee newEmployee)
        {
            string query = SDBQueries.EMPLOYEES_UPDATE_EMPLOYEE;
            string diff = currentEmployee.GetDifferences(newEmployee);

            if(diff.Contains("role_id"))
                query += "role_id = '" + newEmployee.RoleId + "', ";
            if (diff.Contains("name"))
                query += "name = '" + newEmployee.Name + "', ";
            if (diff.Contains("surname"))
                query += "surname = '" + newEmployee.Surname + "', ";
            if (diff.Contains("gender"))
                query += "gender = '" + newEmployee.Gender + "', ";
            if (diff.Contains("age"))
                query += "age = '" + newEmployee.Age + "', ";
            if (diff.Contains("email"))
                query += "email = '" + newEmployee.Email + "', ";
            if (diff.Contains("phone_number"))
                query += "phone_number = '" + newEmployee.PhoneNumber + "', ";
            if (diff.Contains("address"))
                query += "address = '" + newEmployee.Address + "', ";
            if (diff.Contains("birth_date"))
                query += "birth_date = '" + newEmployee.BirthDate + "', ";
            if (diff.Contains("date_joined"))
                query += "date_joined = '" + newEmployee.DateJoined + "', ";
            MessageBox.Show(query.Substring(0, query.Length - 2) + " WHERE id = '" + GetEmployeeId(currentEmployee) + "'");
            query = query.Substring(0, query.Length - 2) + " WHERE id = '" + GetEmployeeId(currentEmployee) + "'";
            
            using(Reader = ExecuteQuery(query))
            {
                Reader.Close();
            }
        }
    }
}
