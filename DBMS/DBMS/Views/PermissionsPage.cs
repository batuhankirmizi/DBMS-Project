using DBMS.Controllers;
using DBMS.Controllers.DB;
using DBMS.Controllers.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DBMS.Views
{
    public partial class PermissionsPage : Form, IViewHandler
    {
        private Form previousForm;

        private PermissionsController controller;

        private Permission currentPermission;

        public PermissionsPage()
        {
            InitializeComponent();

            controller = new PermissionsController();
            controller.Control();

            comboBox.Items.Add("New Permission");
            comboBox.SelectedIndex = 0;
            LinkedList<string> perms = controller.GetPermissionsForComboBox();
            foreach(string permission in perms)
                comboBox.Items.Add(permission);
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
            NavigateTo((IViewHandler) previousForm);
        }

        private void PermissionsPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Destroy();

            GC.Collect();
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            if (textBox_permission_level.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please do not leave the textbox empty.");
                return;
            }

            if (controller.HasPermission(Int32.Parse(textBox_permission_level.Text)))
            {
                MessageBox.Show("Permission " + textBox_permission_level.Text + " already exists.");
                return;
            }

            controller.AddPermission(Int32.Parse(textBox_permission_level.Text));

            PermissionAdded();
        }

        private void PermissionAdded()
        {
            MessageBox.Show("Permission Level " + textBox_permission_level.Text + " added.");

            comboBox.Items.Clear();
            comboBox.Items.Add("New Permission");
            comboBox.SelectedIndex = 0;
            LinkedList<string> perms = controller.GetPermissionsForComboBox();
            foreach (string permission in perms)
                comboBox.Items.Add(permission);
            comboBox.SelectedIndex = comboBox.Items.Count - 1;
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.SelectedIndex != 0)
            {
                button_add.Enabled = false;

                currentPermission = controller.GetPermission(Int32.Parse(comboBox.Text.Split(' ')[0]));
                textBox_permission_level.Text = currentPermission.Facility_access_level.ToString();
            } else {
                button_add.Enabled = true;

                textBox_permission_level.Text = "";
            }
        }

        private void TextBox_permission_level_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_permission_level.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox_permission_level.Text = textBox_permission_level.Text.Remove(textBox_permission_level.Text.Length - 1);
            }
        }
    }
}
