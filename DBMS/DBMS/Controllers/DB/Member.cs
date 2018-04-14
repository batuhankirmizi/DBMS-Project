using System;
using System.Collections.Generic;

namespace DBMS.Controllers.DB
{
    public class Member : Person
    {
        private int payment_id;
        private int height;
        private int weight;

        private DateTime membershipExpiryDate;

        private int weeklyEntranceRight;

        public Member(int permission_id, string name, string surname, char gender, int age, string email, long phoneNumber, string address, DateTime dateJoined,
            DateTime birthDate, int payment_id, int height, int weight, DateTime membershipExpiryDate, int weeklyEntranceRight) :
            base(permission_id, name, surname, gender, age, email, phoneNumber, address, dateJoined, birthDate)
        {
            this.payment_id = payment_id;
            this.height = height;
            this.weight = weight;
            this.membershipExpiryDate = membershipExpiryDate;
            this.weeklyEntranceRight = weeklyEntranceRight;
        }
        
        public int Payment_id { get => payment_id; }
        public int Height { get => height; }
        public int Weight { get => weight; }
        public DateTime MembershipExpiryDate { get => membershipExpiryDate; }
        public int WeeklyEntranceRight { get => weeklyEntranceRight; }

        public override bool Equals(object obj)
        {
            return obj is Member member &&
                   base.Equals(obj) &&
                   payment_id == member.payment_id &&
                   height == member.height &&
                   weight == member.weight &&
                   membershipExpiryDate == member.membershipExpiryDate &&
                   weeklyEntranceRight == member.weeklyEntranceRight &&
                   Payment_id == member.Payment_id &&
                   Height == member.Height &&
                   Weight == member.Weight &&
                   MembershipExpiryDate == member.MembershipExpiryDate &&
                   WeeklyEntranceRight == member.WeeklyEntranceRight;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString()
                + "\n" + payment_id
                + "\n" + height
                + "\n" + weight
                + "\n" + membershipExpiryDate.ToString()
                + "\n" + weeklyEntranceRight.ToString();
        }

        internal LinkedList<string> GetDifferences(Member member)
        {
            LinkedList<string> toReturn = new LinkedList<string>();

            if (!Name.Equals(member.Name))
                toReturn.AddLast("name");
            if (!Surname.Equals(member.Surname))
                toReturn.AddLast("surname");
            if (!Gender.Equals(member.Gender))
                toReturn.AddLast("gender");
            if (Age != member.Age)
                toReturn.AddLast("age");
            if (!Email.Equals(member.Email))
                toReturn.AddLast("email");
            if (PhoneNumber != member.PhoneNumber)
                toReturn.AddLast("phone_number");
            if (!Address.Equals(member.Address))
                toReturn.AddLast("address");
            if (!DateJoined.Equals(member.DateJoined))
                toReturn.AddLast("date_joined");
            if (!BirthDate.Equals(member.BirthDate))
                toReturn.AddLast("birth_date");
            if (height != member.height)
                toReturn.AddLast("height");
            if (weight != member.weight)
                toReturn.AddLast("weight");

            return toReturn;
        }
    }
}
