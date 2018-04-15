using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DBMS.Controllers;
using DBMS.Controllers.DB;
using DBMS.Controllers.Interfaces;

namespace DBMS.Views
{
    public partial class PaymentsPage : Form, IViewHandler
    {
        private Form previousForm;

        private PaymentsController controller;

        private Payment payment;

        public PaymentsPage()
        {
            InitializeComponent();

            controller = new PaymentsController();

            controller.Control();

            LinkedList<Payment> payments;
            if (controller.HasPayments())
            {
                payments = controller.GetPayments();
                LinkedList<string> members = controller.GetMembers();

                foreach (string member in members)
                {
                    comboBox.Items.Add(member);
                }

                comboBox.SelectedItem = comboBox.Items[0];
            }

            comboBox_paid.Items.Add("Yes");
            comboBox_paid.Items.Add("No");

            if(comboBox.Items.Count == 0)
            {
                textBox_description.Enabled = false;
                comboBox_paid.Enabled = false;
                button_change.Enabled = false;
            } else {
                comboBox.SelectedIndex = 0;

                payments = controller.GetPayments();

                textBox_amount.Text = payments.First.Value.Amount.ToString();
                datetime_due_date.Value = payments.First.Value.DueDate;
                textBox_description.Text = payments.First.Value.Description;
                comboBox_paid.Text = payments.First.Value.IsPaid ? "Yes" : "No";

                payment = payments.First.Value;
            }
        }

        public void Activate(Form sender)
        {
            Activate();

            previousForm = sender;

            Show();
        }

        public void Destroy()
        {
            Dispose();
            Close();

            ((IViewHandler) previousForm).Destroy();
        }

        public void NavigateTo(IViewHandler form)
        {
            Hide();

            form.Activate(this);
        }

        private void PaymentsPage_Load(object sender, EventArgs e)
        {

        }

        private void Button_back_Click(object sender, EventArgs e)
        {
            NavigateTo((IViewHandler) previousForm);
        }

        private void PaymentsPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Destroy();

            GC.Collect();
        }

        private void Button_change_Click(object sender, EventArgs e)
        {
            Payment newPayment = new Payment(Int32.Parse(textBox_amount.Text), DateTime.Parse(datetime_due_date.Text), textBox_description.Text, Boolean.Parse(comboBox_paid.Text.Equals("Yes") ? "true" : "false"));

            if (payment.Equals(newPayment))
            {
                MessageBox.Show("Nothing has changed.");
                return;
            }
            
            controller.Change(payment, newPayment);
            payment = newPayment;

            MessageBox.Show("Payment has changed");
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            payment = controller.GetPayment(Int32.Parse(comboBox.Text.Split('-')[0]));
        }
    }
}
