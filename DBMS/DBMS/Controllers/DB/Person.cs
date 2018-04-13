using System;

namespace DBMS.Controllers.DB
{
    public abstract class Person
    {
        private int permission_id;
        
        private string name;
        private string surname;

        private char gender;

        private int age;

        private string email;

        private long phoneNumber;

        private string address;

        private DateTime dateJoined;

        private DateTime birthDate;

        protected Person(int permission_id, string name, string surname, char gender, int age, string email, long phoneNumber,
            string address, DateTime dateJoined, DateTime birthDate)
        {
            this.permission_id = permission_id;
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.surname = surname ?? throw new ArgumentNullException(nameof(surname));
            this.gender = gender;
            this.age = age;
            this.email = email ?? throw new ArgumentNullException(nameof(email));
            this.phoneNumber = phoneNumber;
            this.address = address ?? throw new ArgumentNullException(nameof(address));
            this.dateJoined = dateJoined;
            this.birthDate = birthDate;
        }

        public int Permission_id { get => permission_id; }
        public string Name { get => name; }
        public string Surname { get => surname; }
        public char Gender { get => gender; }
        public int Age { get => age; }
        public string Email { get => email; }
        public long PhoneNumber { get => phoneNumber; }
        public string Address { get => address; }
        public DateTime DateJoined { get => dateJoined; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   Permission_id == person.Permission_id &&
                   Name == person.Name &&
                   Surname == person.Surname &&
                   Gender == person.Gender &&
                   Age == person.Age &&
                   Email == person.Email &&
                   PhoneNumber == person.PhoneNumber &&
                   Address == person.Address &&
                   DateJoined == person.DateJoined &&
                   BirthDate == person.BirthDate;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return permission_id +
                "\n" + name +
                "\n" + surname +
                "\n" + gender +
                "\n" + age +
                "\n" + email +
                "\n" + phoneNumber +
                "\n" + address +
                "\n" + dateJoined +
                "\n" + birthDate;
        }
    }
}
