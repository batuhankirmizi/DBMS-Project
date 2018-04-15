using System;

namespace DBMS.Controllers.DB
{
    public class Payment
    {
        private int amount;

        private DateTime dueDate;

        private string description;

        private bool isPaid;

        public Payment(int amount, DateTime dueDate, string description, bool isPaid)
        {
            this.amount = amount;
            this.dueDate = dueDate;
            this.description = description ?? throw new ArgumentNullException(nameof(description));
            this.isPaid = isPaid;
        }

        public int Amount { get => amount; }
        public DateTime DueDate { get => dueDate; }
        public string Description { get => description; }
        public bool IsPaid { get => isPaid; }

        public override bool Equals(object obj)
        {
            return obj is Payment payment &&
                   amount == payment.amount &&
                   dueDate == payment.dueDate &&
                   description.Equals(payment.description) &&
                   isPaid == payment.isPaid;
        }

        public override string ToString()
        {
            return amount.ToString() + "\n" +
                dueDate.ToString() + "\n" +
                description + "\n" +
                isPaid;
        }
    }
}
