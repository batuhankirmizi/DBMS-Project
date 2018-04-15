using System;
using System.Collections.Generic;

namespace DBMS.Controllers.DB
{
    internal class Facility
    {
        private int permission;
        private string name;

        public Facility(int permission, string name)
        {
            this.permission = permission;
            this.name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public int Permission { get => permission; set => permission = value; }
        public string Name { get => name; set => name = value; }

        public override bool Equals(object obj)
        {
            return obj is Facility facility &&
                   permission == facility.permission &&
                   name.Equals(facility.name);
        }

        public override int GetHashCode()
        {
            var hashCode = -323882966;
            hashCode = hashCode * -1521134295 + permission.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + Permission.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }

        public override string ToString()
        {
            return permission + "\n" +
                name + "\n";
        }
    }
}
