using System;
using System.Collections.Generic;

namespace DBMS.Controllers.DB
{
    public class Employee
    {
        private int roleId;
        private string name;
        private string surname;
        private char gender;
        private int age;
        private string email;
        private long phoneNumber;
        private string address;
        private DateTime birthDate;
        private DateTime dateJoined;

        public Employee(int roleId, string name, string surname, char gender, int age, string email, long phoneNumber, string address, DateTime birthDate, DateTime dateJoined)
        {
            this.roleId = roleId;
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.surname = surname ?? throw new ArgumentNullException(nameof(surname));
            this.gender = gender;
            this.age = age;
            this.email = email ?? throw new ArgumentNullException(nameof(email));
            this.phoneNumber = phoneNumber;
            this.address = address ?? throw new ArgumentNullException(nameof(address));
            this.birthDate = birthDate;
            this.dateJoined = dateJoined;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public char Gender { get => gender; set => gender = value; }
        public int Age { get => age; set => age = value; }
        public string Email { get => email; set => email = value; }
        public long PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public DateTime DateJoined { get => dateJoined; set => dateJoined = value; }
        public int RoleId { get => roleId; set => roleId = value; }

        public override bool Equals(object obj)
        {
            return obj is Employee employee &&
                   roleId == employee.roleId &&
                   name == employee.name &&
                   surname == employee.surname &&
                   gender == employee.gender &&
                   age == employee.age &&
                   email == employee.email &&
                   phoneNumber == employee.phoneNumber &&
                   address == employee.address &&
                   birthDate == employee.birthDate &&
                   dateJoined == employee.dateJoined &&
                   Name == employee.Name &&
                   Surname == employee.Surname &&
                   Gender == employee.Gender &&
                   Age == employee.Age &&
                   Email == employee.Email &&
                   PhoneNumber == employee.PhoneNumber &&
                   Address == employee.Address &&
                   BirthDate == employee.BirthDate &&
                   DateJoined == employee.DateJoined &&
                   RoleId == employee.RoleId;
        }

        public override int GetHashCode()
        {
            var hashCode = -1634253788;
            hashCode = hashCode * -1521134295 + roleId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(surname);
            hashCode = hashCode * -1521134295 + gender.GetHashCode();
            hashCode = hashCode * -1521134295 + age.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(email);
            hashCode = hashCode * -1521134295 + phoneNumber.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(address);
            hashCode = hashCode * -1521134295 + birthDate.GetHashCode();
            hashCode = hashCode * -1521134295 + dateJoined.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Surname);
            hashCode = hashCode * -1521134295 + Gender.GetHashCode();
            hashCode = hashCode * -1521134295 + Age.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            hashCode = hashCode * -1521134295 + PhoneNumber.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Address);
            hashCode = hashCode * -1521134295 + BirthDate.GetHashCode();
            hashCode = hashCode * -1521134295 + DateJoined.GetHashCode();
            hashCode = hashCode * -1521134295 + RoleId.GetHashCode();
            return hashCode;
        }

        public string GetDifferences(Employee employee)
        {
            string diff = "";

            if(roleId != employee.roleId)
                diff += "role_id ";
            if(!name.Equals(employee.name))
                diff += "name ";
            if(!surname.Equals(employee.surname))
                diff += "surname ";
            if(!gender.Equals(employee.gender))
                diff += "gender ";
            if(!age.Equals(employee.age))
                diff += "age ";
            if(!email.Equals(employee.email))
                diff += "email ";
            if(!address.Equals(employee.address))
                diff += "address ";
            if(!phoneNumber.Equals(employee.phoneNumber))
                diff += "phone_number ";
            if(!birthDate.Equals(employee.birthDate))
                diff += "name ";
            if(!DateJoined.Equals(employee.dateJoined))
                diff += "name ";

            return diff;
        }
    }
}
