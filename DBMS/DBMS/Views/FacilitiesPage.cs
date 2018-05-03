using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DBMS.Controllers;
using DBMS.Controllers.DB;
using DBMS.Controllers.Interfaces;

namespace DBMS.Views
{
    public partial class FacilitiesPage : Form, IViewHandler
    {
        private FacilitiesController controller;

        private Form previousForm;

        private Facility currentFacility;

        public FacilitiesPage()
        {
            InitializeComponent();

            controller = new FacilitiesController();
            controller.Control();

            comboBox.Items.Add("New Facility");
            comboBox.SelectedIndex = 0;
            currentFacility = null;

            LinkedList<string> facilities = controller.GetFacilities();
            foreach(string facility in facilities)
                comboBox.Items.Add(facility);
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

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_add.Text = comboBox.SelectedItem.ToString().Equals("New Facility") ? "ADD" : "CHANGE";

            if(comboBox.SelectedItem.ToString().Equals("New Facility"))
            {
                textBox_permission.Enabled = true;

                textBox_permission.Text = "";
                textBox_name.Text = "";

                button1.Visible = false;
            } else
            {
                textBox_permission.Enabled = false;

                currentFacility = controller.GetFacility(comboBox.Text.Split('-')[1].Trim());

                textBox_permission.Text = currentFacility.Permission.ToString();
                textBox_name.Text = currentFacility.Name;

                button1.Visible = true;
            }
        }

        private void TextBox_permission_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_permission.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox_permission.Text = textBox_permission.Text.Remove(textBox_permission.Text.Length - 1);
            }

            if(textBox_permission.Text.Length > 5)
            {
                MessageBox.Show("Permission number length cannot be longer than 5");
                textBox_permission.Text = textBox_permission.Text.Remove(textBox_permission.Text.Length - 1);
            }
        }

        private void TextBox_name_TextChanged(object sender, EventArgs e)
        {
            if (textBox_name.Text.Length > 25)
            {
                MessageBox.Show("Name cannot be longer than 25");
                textBox_name.Text = textBox_name.Text.Remove(textBox_name.Text.Length - 1);
            }
        }

        private void FacilitiesPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Destroy();

            GC.Collect();
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            if (button_add.Text.Equals("ADD"))
            {
                if (textBox_permission.Text.Equals("") || textBox_name.Text.Equals(""))
                {
                    MessageBox.Show("Please do not leave any empty fields");
                    return;
                }

                if (controller.GetPermissionId(Int32.Parse(textBox_permission.Text)) == 0)
                    controller.AddPermission(Int32.Parse(textBox_permission.Text));

                currentFacility = new Facility(Int32.Parse(textBox_permission.Text), textBox_name.Text);

                controller.AddFacility(currentFacility);

                MessageBox.Show("Facility " + currentFacility.Name + " added");

                FacilityAdded();
            } else {
                Facility newFacility = new Facility(Int32.Parse(textBox_permission.Text), textBox_name.Text);

                if (currentFacility.Equals(newFacility))
                {
                    MessageBox.Show("Nothing has changed.");
                } else {
                    int i = comboBox.SelectedIndex;

                    controller.ChangeFacility(currentFacility, newFacility);

                    MessageBox.Show("Facility " + currentFacility.Name + " has changed");

                    comboBox.Items.Clear();
                    comboBox.Items.Add("New Facility");
                    LinkedList<string> facilities = controller.GetFacilities();
                    foreach (string facility in facilities)
                        comboBox.Items.Add(facility);

                    comboBox.SelectedIndex = i;
                }
            }
        }

        private void FacilityAdded()
        {
            comboBox.Items.Clear();
            comboBox.Items.Add("New Facility");
            LinkedList<string> facilities = controller.GetFacilities();
            foreach (string facility in facilities)
                comboBox.Items.Add(facility);

            comboBox.SelectedIndex = comboBox.Items.Count - 1;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            controller.DeleteFacility(textBox_name.Text);

            FacilityDeleted();
        }

        private void FacilityDeleted()
        {
            MessageBox.Show("Facility " + textBox_name.Text + " deleted.");
            
            comboBox.Items.Clear();
            comboBox.Items.Add("New Facility");
            comboBox.SelectedIndex = 0;
            currentFacility = null;
            LinkedList<string> facilities = controller.GetFacilities();
            foreach (string facility in facilities)
                comboBox.Items.Add(facility);

            textBox_permission.Text = "";
            textBox_name.Text = "";
        }
    }
}
