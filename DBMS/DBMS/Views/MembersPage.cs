using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DBMS.Controllers;
using DBMS.Controllers.DB;
using DBMS.Controllers.Interfaces;

namespace DBMS.Views
{
    public partial class MembersPage : Form, IViewHandler
    {
        private Form previousForm;

        private MembersController controller;

        private LinkedList<TextBox> textBoxes = new LinkedList<TextBox>();

        private Member member;
        
        public MembersPage()
        {
            InitializeComponent();

            controller = new MembersController();
            controller.Control();

            combo_box.Items.Add("New Member");
            combo_box.SelectedItem = combo_box.Items[0];
            foreach(Object o in controller.GetMembers())
                combo_box.Items.Add(o);

            textBoxes.AddLast(textbox_name);
            textBoxes.AddLast(textbox_surname);
            textBoxes.AddLast(textbox_age);
            textBoxes.AddLast(textbox_mem_duration);
            textBoxes.AddLast(textbox_weekly_entrance_right);
            textBoxes.AddLast(textbox_email);
            textBoxes.AddLast(textbox_phone_number);
            textBoxes.AddLast(textbox_address);
            textBoxes.AddLast(textbox_height);
            textBoxes.AddLast(textbox_weight);
            textBoxes.AddLast(textbox_permission_level);
            textBoxes.AddLast(textbox_monthly_payment);
        }

        public void Activate(Form sender)
        {
            Activate();

            previousForm = sender;

            Show();
        }

        public void NavigateTo(IViewHandler form)
        {
            Hide();

            form.Activate(this);
        }

        private void Members_FormClosing(object sender, FormClosingEventArgs e)
        {
            Destroy();

            GC.Collect();
        }

        private void Button_back_Click(object sender, System.EventArgs e)
        {
            NavigateTo((IViewHandler) previousForm);
        }

        public void Logout()
        {
            SSession.End();
        }

        public void Destroy()
        {
            Dispose();
            Close();

            ((IViewHandler) previousForm).Destroy();
        }

        private void MembersPage_Load(object sender, EventArgs e)
        {
            comboBox_gender.Text = "Male";
        }

        private void Combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(combo_box.SelectedItem.Equals("New Member"))
            {
                member = null;

                button_register.Text = "REGISTER";
                button_delete.Visible = false;

                foreach(TextBox textBox in textBoxes)
                {
                    textBox.Text = "";
                    textBox.Enabled = true;
                }
            }
            else {
                // Get member from the database
                member = controller.GetMember(Int32.Parse(combo_box.SelectedItem.ToString().Split(' ')[0]));

                // Change the text on the textboxes
                textbox_name.Text = member.Name;
                textbox_surname.Text = member.Surname;
                textbox_age.Text = member.Age.ToString();
                textbox_email.Text = member.Email;
                comboBox_gender.Text = member.Gender.Equals('M') ? "Male" : "Female";
                textbox_phone_number.Text = member.PhoneNumber.ToString();
                textbox_address.Text = member.Address;
                textbox_height.Text = member.Height.ToString();
                textbox_height.Enabled = false;
                textbox_weight.Text = member.Weight.ToString();
                textbox_weight.Enabled = false;
                textbox_mem_duration.Text = Math.Abs(member.DateJoined.Month - member.MembershipExpiryDate.Month).ToString();
                textbox_mem_duration.Enabled = false;
                textbox_weekly_entrance_right.Text = member.WeeklyEntranceRight.ToString();
                textbox_weekly_entrance_right.Enabled = false;
                textbox_monthly_payment.Text = (Int32.Parse(controller.GetMonthlyPayment(member).ToString()) / Int32.Parse(Math.Abs(member.DateJoined.Month - member.MembershipExpiryDate.Month).ToString())).ToString();
                textbox_monthly_payment.Enabled = false;
                textbox_permission_level.Text = controller.GetPermissionLevel(member).ToString();
                textbox_permission_level.Enabled = false;
                date_birth.Value = member.BirthDate;
                date_joined.Value = member.DateJoined;

                // Change the text on the button
                button_register.Text = "CHANGE";
                button_delete.Visible = true;
            }
        }

        private void Textbox_age_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textbox_age.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textbox_age.Text = textbox_age.Text.Remove(textbox_age.Text.Length - 1);
            }
        }

        private void Textbox_mem_duration_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textbox_mem_duration.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textbox_mem_duration.Text = textbox_mem_duration.Text.Remove(textbox_mem_duration.Text.Length - 1);
            }
        }

        private void Textbox_weight_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textbox_weight.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textbox_weight.Text = textbox_weight.Text.Remove(textbox_weight.Text.Length - 1);
            }
        }

        private void Textbox_height_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textbox_height.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textbox_height.Text = textbox_height.Text.Remove(textbox_height.Text.Length - 1);
            }
        }

        private void Textbox_weekly_entrance_right_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textbox_weekly_entrance_right.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textbox_weekly_entrance_right.Text = textbox_weekly_entrance_right.Text.Remove(textbox_weekly_entrance_right.Text.Length - 1);
            }
        }

        private void Button_register_Click(object sender, EventArgs e)
        {
                                         // REGISTER //
            if(button_register.Text.Equals("REGISTER"))
            {
                // Check if there is any empty textboxes
                foreach (TextBox textBox in textBoxes)
                {
                    if (textBox.Text.ToString().Trim().Equals("") || comboBox_gender.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Please do not leave any empty fields.");
                        return;
                    }

                    if (textBox.Text.Contains("\""))
                    {
                        MessageBox.Show("Textboxes cannot contain \"");
                        return;
                    }

                    // Textbox controls
                    if (Int32.Parse(textbox_age.Text) < 2 || Int32.Parse(textbox_age.Text) > 120)
                    {
                        MessageBox.Show("Invalid Age");
                        return;
                    }
                }

                // Add Payment
                DateTime dueDate = DateTime.Today.AddMonths(Int32.Parse(textbox_mem_duration.Text));
                Payment payment = new Payment(Int32.Parse(textbox_monthly_payment.Text) * Int32.Parse(textbox_mem_duration.Text), dueDate, "default desc", false);
                controller.AddPayment(payment);

                // Add User
                int permissionId = controller.GetPermissionId(Int32.Parse(textbox_permission_level.Text));

                member = new Member(permissionId, textbox_name.Text, textbox_surname.Text, Char.Parse(comboBox_gender.Text.Substring(0,1).ToUpper()), Int32.Parse(textbox_age.Text),
                    textbox_email.Text, Int64.Parse(textbox_phone_number.Text), textbox_address.Text, DateTime.Parse(date_joined.Text), DateTime.Parse(date_birth.Text),
                    controller.GetMaxPaymentId(), Int32.Parse(textbox_height.Text), Int32.Parse(textbox_weight.Text), dueDate,
                    Int32.Parse(textbox_weekly_entrance_right.Text));

                controller.AddMember(member);
                controller.AddMembership(member);
                controller.AddMemberImprovement(member);

                MessageBox.Show("Member " + member.Name + " has been registered.");

                // Reload Form
                MemberAdded();

                                            // CHANGE //
            } else {
                Member newMember = null;

                newMember = new Member(controller.GetPermissionId(Int32.Parse(textbox_permission_level.Text)), textbox_name.Text, textbox_surname.Text,
                    Char.Parse(comboBox_gender.Text.Substring(0, 1)), Int32.Parse(textbox_age.Text), textbox_email.Text, Int64.Parse(textbox_phone_number.Text),
                    textbox_address.Text, DateTime.Parse(date_joined.Text), DateTime.Parse(date_birth.Text), member.Payment_id, Int32.Parse(textbox_height.Text),
                    Int32.Parse(textbox_weight.Text), member.MembershipExpiryDate, Int32.Parse(textbox_weekly_entrance_right.Text));

                if (member.Equals(newMember))
                    MessageBox.Show("Nothing has changed.");
                else {
                    controller.UpdateMember(member, newMember);
                    MessageBox.Show("Member " + member.Name + " has been changed.");

                    MemberChanged();
                }
            }
        }

        private void Textbox_monthly_payment_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textbox_monthly_payment.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textbox_monthly_payment.Text = textbox_monthly_payment.Text.Remove(textbox_monthly_payment.Text.Length - 1);
            }
        }

        private void Textbox_name_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textbox_name.Text, "[0-9]"))
            {
                MessageBox.Show("Please enter only letters.");
                textbox_name.Text = textbox_name.Text.Remove(textbox_name.Text.Length - 1);
            }
        }

        private void Textbox_surname_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textbox_surname.Text, "[0-9]"))
            {
                MessageBox.Show("Please enter only letters.");
                textbox_surname.Text = textbox_surname.Text.Remove(textbox_surname.Text.Length - 1);
            }
        }

        private void Textbox_phone_number_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textbox_phone_number.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textbox_phone_number.Text = textbox_phone_number.Text.Remove(textbox_phone_number.Text.Length - 1);
            }
        }

        private void MemberAdded()
        {
            combo_box.Items.Clear();

            combo_box.Items.Add("New Member");
            foreach (Object o in controller.GetMembers())
                combo_box.Items.Add(o);

            combo_box.SelectedItem = combo_box.Items[combo_box.Items.Count - 1];
        }

        private void MemberChanged()
        {
            int i = combo_box.SelectedIndex;

            combo_box.Items.Clear();

            combo_box.Items.Add("New Member");
            foreach (Object o in controller.GetMembers())
                combo_box.Items.Add(o);
            
            combo_box.SelectedIndex = i;
        }

        private void Textbox_permission_level_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textbox_permission_level.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textbox_permission_level.Text = textbox_permission_level.Text.Remove(textbox_permission_level.Text.Length - 1);
            }
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            controller.DeleteMember(member);

            MessageBox.Show("Member " + member.Name + " has been deleted.");

            combo_box.Items.Remove(combo_box.SelectedItem);
            combo_box.SelectedItem = combo_box.Items[0];
        }
    }
}
