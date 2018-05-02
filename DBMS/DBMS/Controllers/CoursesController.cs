using DBMS.Controllers.DB;
using System;
using System.Collections.Generic;

namespace DBMS.Controllers
{
    class CoursesController : Controller
    {
        public override bool Control()
        {
            Connect(SDBStatics.MAIN_DB);

            return connection != null;
        }

        internal void AddCourse(Course currentCourse)
        {
            string query = SDBQueries.COURSES_ADD_COURSE + currentCourse.EmployeeId + "', '" + currentCourse.Name + "', '" + currentCourse.Description + "', '" +
                currentCourse.Day + "', '" + currentCourse.IsActive + "');";
            using(Reader = ExecuteQuery(query))
            {
                Reader.Close();
            }
        }

        internal int GetEmployeeId(string employeeName)
        {
            int toReturn = 0;
            using(Reader = ExecuteQuery(SDBQueries.COURSES_GET_EMP_ID + employeeName + "'"))
            {
                while (Reader.Read())
                    toReturn = Int32.Parse(Reader["id"].ToString());

                Reader.Close();
            }

            return toReturn;
        }

        internal bool HasCourse()
        {
            using (Reader = ExecuteQuery(SDBQueries.COURSES_GET_COURSES))
            {
                while (Reader.Read())
                {
                    return true;
                }

                Reader.Close();

                return false;
            }
        }

        internal LinkedList<string> GetCoursesForComboox()
        {
            LinkedList<string> toReturn = new LinkedList<string>();
            using(Reader = ExecuteQuery(SDBQueries.COURSES_GET_COURSES))
            {
                while(Reader.Read())
                    toReturn.AddLast(Reader["id"].ToString() + " - " + Reader["name"]);

                Reader.Close();
            }

            return toReturn;
        }

        internal Course GetCourse(int courseId)
        {
            Course toReturn = null;
            using(Reader = ExecuteQuery(SDBQueries.COURSES_GET_COURSE + courseId))
            {
                while(Reader.Read())
                    toReturn = new Course(Int32.Parse(Reader["employee_id"].ToString()),
                        Reader["name"].ToString(), Reader["description"].ToString(), Reader["course_day"].ToString(), Boolean.Parse(Reader["is_active"].ToString()));
               Reader.Close();
            }

            return toReturn;
        }

        internal string GetEmployeeName(int employeeId)
        {
            string name = "";
            using(Reader = ExecuteQuery(SDBQueries.COURSES_GET_EMP_NAME + employeeId))
            {
                while (Reader.Read())
                    name = Reader["name"].ToString();
                Reader.Close();
            }

            return name;
        }

        internal void DeleteCourse(int id)
        {
            using(Reader = ExecuteQuery(SDBQueries.COURSES_DELETE_COURSE + id))
            {
                Reader.Close();
            }
        }

        internal void Change(Course currentCourse, Course newCourse)
        {
            string query = SDBQueries.COURSES_CHANGE_COURSE;
            string diff = currentCourse.GetDifferences(newCourse);
            if (diff.Contains("employee_id"))
                query += "employee_id = '" + newCourse.EmployeeId + "', ";
            if (diff.Contains("name"))
                query += "name = '" + newCourse.Name + "', ";
            if (diff.Contains("description"))
                query += "description = '" + newCourse.Description + "', ";
            if (diff.Contains("course_day"))
                query += "course_day = '" + newCourse.Day + "', ";
            if (diff.Contains("is_active"))
                query += "is_acitve = '" + newCourse.IsActive + "', ";

            using(Reader = ExecuteQuery(query.Substring(0, query.Length - 2)))
            {
                Reader.Close();
            }
        }
    }
}
