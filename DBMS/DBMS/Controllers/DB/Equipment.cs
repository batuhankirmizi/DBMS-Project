using System;
using System.Collections.Generic;

namespace DBMS.Controllers.DB
{
    class Equipment
    {
        private string name;
        
        private float price;

        private string condition;

        private DateTime dateOfArrival;

        private int warrantyDuration;

        public Equipment(string name, float price, string condition, DateTime dateOfArrival, int warrantyDuration)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.price = price;
            this.condition = condition ?? throw new ArgumentNullException(nameof(condition));
            this.dateOfArrival = dateOfArrival;
            this.warrantyDuration = warrantyDuration;
        }

        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public string Condition { get => condition; set => condition = value; }
        public DateTime DateOfArrival { get => dateOfArrival; set => dateOfArrival = value; }
        public int WarrantyDuration { get => warrantyDuration; set => warrantyDuration = value; }

        public override bool Equals(object obj)
        {
            return obj is Equipment equipment &&
                   name.Equals(equipment.name) &&
                   price == equipment.price &&
                   condition.Equals(equipment.condition) &&
                   dateOfArrival.Equals(equipment.dateOfArrival) &&
                   warrantyDuration == equipment.warrantyDuration;
        }

        public override int GetHashCode()
        {
            var hashCode = -1869484632;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + price.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(condition);
            hashCode = hashCode * -1521134295 + dateOfArrival.GetHashCode();
            hashCode = hashCode * -1521134295 + warrantyDuration.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Price.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Condition);
            hashCode = hashCode * -1521134295 + DateOfArrival.GetHashCode();
            hashCode = hashCode * -1521134295 + WarrantyDuration.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return name + "\n" +
                price + "\n" +
                condition + "\n" +
                dateOfArrival + "\n" +
                warrantyDuration;
        }

        public LinkedList<string> GetDifferences(Equipment equipment)
        {
            LinkedList<string> toReturn = new LinkedList<string>();

            if(!name.Equals(equipment.name))
                toReturn.AddLast("name");
            if(price != equipment.price)
                toReturn.AddLast("price");
            if(!condition.Equals(equipment.condition))
                toReturn.AddLast("condition");
            if(!dateOfArrival.Equals(equipment.dateOfArrival))
                toReturn.AddLast("date_of_arrival");
            if(warrantyDuration != equipment.warrantyDuration)
                toReturn.AddLast("warranty");

            return toReturn;
        }
    }
}
