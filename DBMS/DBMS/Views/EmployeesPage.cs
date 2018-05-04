using DBMS.Controllers;
using DBMS.Controllers.DB;
using DBMS.Controllers.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DBMS.Views
{
    public partial class EmployeesPage : Form, IViewHandler
    {
        private Form previousForm;

        private Employee currentEmployee;

        private EmployeesController controller = null;

        private LinkedList<TextBox> textBoxes = null;

        public EmployeesPage()
        {
            InitializeComponent();

            controller = new EmployeesController();
            controller.Control();
            
            textBoxes = new LinkedList<TextBox>();
            textBoxes.AddLast(textbox_name);
            textBoxes.AddLast(textbox_surname);
            textBoxes.AddLast(textbox_email);
            textBoxes.AddLast(textbox_phone_number);
            textBoxes.AddLast(textbox_address);
            textBoxes.AddLast(textbox_age);
            comboBox_gender.SelectedIndex = 0;

            comboBox.Items.Add("New Employee");
            if (controller.HasEmployees())
                foreach (string s in controller.GetEmployeesComboBox())
                    comboBox.Items.Add(s);
            comboBox.SelectedIndex = 0;
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

            ((IViewHandler)previousForm).Destroy();

            GC.Collect();
        }

        public void NavigateTo(IViewHandler form)
        {
            Hide();

            form.Activate(this);
        }

        private void Button_back_Click(object sender, EventArgs e)
        {
            NavigateTo((IViewHandler)previousForm);
        }

        private void EmployeesPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Destroy();

            GC.Collect();
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox.SelectedIndex != 0) {
                button_delete.Visible = true;

                currentEmployee = controller.GetEmployee(Int32.Parse(comboBox.Text.Split(' ')[0]));
                textbox_name.Text = currentEmployee.Name;
                textbox_surname.Text = currentEmployee.Surname;
                textbox_email.Text = currentEmployee.Email;
                textbox_phone_number.Text = currentEmployee.PhoneNumber.ToString();
                textbox_address.Text = currentEmployee.Address;
                comboBox_gender.SelectedIndex = currentEmployee.Gender.Equals('M') ? 0 : 1;
                textbox_age.Text = currentEmployee.Age.ToString();
                date_birth.Text = currentEmployee.BirthDate.ToString();
                date_joined.Text = currentEmployee.DateJoined.ToString();
                comboBox_role.Text = controller.GetRoleName(currentEmployee.RoleId);

                button_register.Text = "CHANGE";
            } else {
                button_delete.Visible = false;

                foreach (TextBox box in textBoxes)
                    box.Text = "";

                button_register.Text = "ADD";
            }
        }

        private void Button_register_Click(object sender, EventArgs e)
        {
            if (button_register.Text.Equals("ADD")) {
                foreach (TextBox box in textBoxes)
                    if (box.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Please do not leave any empty fields.");
                        return;
                    }
                
                currentEmployee = new Employee(controller.GetRoleId(comboBox_role.Text), textbox_name.Text, textbox_surname.Text, Char.Parse(comboBox_gender.Text.Substring(0,1)),
                    Int32.Parse(textbox_age.Text), textbox_email.Text, long.Parse(textbox_phone_number.Text), textbox_address.Text,
                    DateTime.Parse(date_birth.Text), DateTime.Parse(date_joined.Text));
                controller.AddEmployee(currentEmployee);

                MessageBox.Show("Employee " + currentEmployee.Name + " registered.");

                EmployeeChanged(comboBox.Items.Count);
            } else {
                Employee currentEmployee = controller.GetEmployee(int.Parse(comboBox.Text.Split(' ')[0]));
                Employee newEmployee = new Employee(controller.GetRoleId(comboBox_role.Text), textbox_name.Text, textbox_surname.Text, Char.Parse(comboBox_gender.Text.Substring(0, 1)),
                    Int32.Parse(textbox_age.Text), textbox_email.Text, long.Parse(textbox_phone_number.Text), textbox_address.Text,
                    DateTime.Parse(date_birth.Text), DateTime.Parse(date_joined.Text));

                if (currentEmployee.GetDifferences(newEmployee).Equals(""))
                {
                    MessageBox.Show("Nothing has changed.");
                    return;
                }
                
                controller.ChangeEmployee(currentEmployee, newEmployee);

                MessageBox.Show("Employee " + currentEmployee.Name + " changed.");

                EmployeeChanged(comboBox.SelectedIndex);
            }
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            controller.DeleteEmployee(Int32.Parse(comboBox.Text.Split(' ')[0]));

            MessageBox.Show("Employee " + currentEmployee.Name + " deleted.");

            EmployeeChanged(0);
        }

        private void EmployeeChanged(int newIndex)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add("New Employee");
            if (controller.HasEmployees())
                foreach (string s in controller.GetEmployeesComboBox())
                    comboBox.Items.Add(s);

            comboBox.SelectedIndex = newIndex;
        }

        private void EmployeesPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'main_DatabaseDataSet1.Roles' table. You can move, or remove it, as needed.
            this.rolesTableAdapter.Fill(this.main_DatabaseDataSet1.Roles);

        }
    }
}
