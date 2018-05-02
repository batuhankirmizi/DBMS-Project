using System;
using System.Collections.Generic;

namespace DBMS.Controllers.DB
{
    public class Course
    {
        private int employeeId;
        private string name;
        private string description;
        private string day;
        private bool isActive;

        public Course(int employeeId, string name, string description, string day, bool isActive)
        {
            this.employeeId = employeeId;
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.description = description ?? throw new ArgumentNullException(nameof(description));
            this.day = day ?? throw new ArgumentNullException(nameof(day));
            this.isActive = isActive;
        }

        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Day { get => day; set => day = value; }
        public bool IsActive { get => isActive; set => isActive = value; }

        public override bool Equals(object obj)
        {
            return obj is Course course &&
                   employeeId == course.employeeId &&
                   name.Equals(course.name) &&
                   description.Equals(course.description) &&
                   day.Equals(course.day) &&
                   isActive == course.isActive;
        }

        public override int GetHashCode()
        {
            var hashCode = -305247789;
            hashCode = hashCode * -1521134295 + employeeId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(description);
            return hashCode;
        }

        internal string GetDifferences(Course newCourse)
        {
            string differences = "";

            if(employeeId != newCourse.employeeId)
                differences += "employee_id ";
            if(!name.Equals(newCourse.name))
                differences += "name ";
            if(!description.Equals(newCourse.description))
                differences += "description ";
            if(!day.Equals(newCourse.day))
                differences += "course_day ";
            if(!isActive.Equals(newCourse.isActive))
                differences += "is_active ";

            return differences;
        }

        public override string ToString()
        {
            return employeeId + "\n" +
                name + "\n" +
                description + "\n" +
                day + "\n" +
                isActive;
        }
    }
}
