using DBMS.Controllers.DB;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DBMS.Controllers
{
    class PaymentsController : Controller
    {
        public override bool Control()
        {
            Connect(SDBStatics.MAIN_DB);

            return connection != null;
        }

        internal int GetPaymentId(Payment payment)
        {
            string query = SDBQueries.PAYMENT_GET_ID + "'" + payment.Amount.ToString() +
                "' and description = '" + payment.Description + "' and is_paid = '" + Int32.Parse(payment.IsPaid ? "1" : "0") + "'";

            int id = 0;
            using(Reader = ExecuteQuery(query))
            {
                while(Reader.Read())
                    id = Int32.Parse(Reader["id"].ToString());

                Reader.Close();
            }

            return id;
        }

        internal LinkedList<Payment> GetPayments()
        {
            LinkedList<Payment> toReturn = new LinkedList<Payment>();
            using(Reader = ExecuteQuery(SDBQueries.PAYMENT_GET_PAYMENTS))
            {
                while (Reader.Read())
                {
                    toReturn.AddLast(new Payment(Int32.Parse(Reader["amount"].ToString()), DateTime.Parse(Reader["payment_due_date"].ToString()),
                        Reader["description"].ToString(), Boolean.Parse(Reader["is_paid"].ToString())));
                }
            }

            return toReturn;
        }

        internal LinkedList<string> GetMembers()
        {
            LinkedList<string> toReturn = new LinkedList<string>();
            using(Reader = ExecuteQuery(SDBQueries.PAYMENT_GET_PAYMENTS))
            {
                while (Reader.Read())
                    toReturn.AddLast(Reader["id"] + " - " + Reader["name"] + " " + Reader["surname"]);
            }

            return toReturn;
        }

        internal bool HasPayments()
        {
            int i = 0;
            using(Reader = ExecuteQuery(SDBQueries.PAYMENT_GET_PAYMENTS))
            {
                while (Reader.Read())
                {
                    i++;
                    if(i > 0) break;
                }

                Reader.Close();
            }

            return i > 0;
        }

        internal Payment GetPayment(int paymentId)
        {
            Payment payment = null;
            using(Reader = ExecuteQuery(SDBQueries.PAYMENT_GET_PAYMENT + paymentId))
            {
                while (Reader.Read())
                {
                    payment = new Payment(Int32.Parse(Reader["amount"].ToString()), DateTime.Parse(Reader["payment_due_date"].ToString()), Reader["description"].ToString(), Boolean.Parse(Reader["is_paid"].ToString()));
                }
            }

            return payment;
        }

        internal void Change(Payment oldPayment, Payment newPayment)
        {
            bool ch = false;
            if (oldPayment.IsPaid != newPayment.IsPaid)
            {
                ch = true;
                using (Reader = ExecuteQuery(SDBQueries.PAYMENT_CHANGE + " is_paid = '" + (newPayment.IsPaid ? "1" : "0") + "' WHERE id = " + GetPaymentId(oldPayment)))
                {
                    Reader.Close();
                }
            }

            if(ch)
                oldPayment = new Payment(oldPayment.Amount, oldPayment.DueDate, oldPayment.Description, !oldPayment.IsPaid);

            if (!oldPayment.Description.Equals(newPayment.Description))
            {
                using (Reader = ExecuteQuery(SDBQueries.PAYMENT_CHANGE + " description = '" + newPayment.Description + "' WHERE id = " + GetPaymentId(oldPayment)))
                {
                    Reader.Close();
                }
            }
            
        }
    }
}
