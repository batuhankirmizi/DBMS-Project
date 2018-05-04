using DBMS.Controllers;
using DBMS.Controllers.DB;
using DBMS.Controllers.Interfaces;
using System;
using System.Windows.Forms;

namespace DBMS.Views
{
    public partial class RolesPage : Form, IViewHandler
    {
        private Form previousForm;

        private RolesPageController controller;

        private Role currentRole;

        public RolesPage()
        {
            InitializeComponent();

            controller = new RolesPageController();
            controller.Control();

            comboBox.Items.Add("New Role");
            if(controller.HasRoles())
                foreach(string str in controller.GetRolesCombo())
                    comboBox.Items.Add(str);

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

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox.SelectedIndex != 0) {
                button_register.Text = "CHANGE";

                currentRole = controller.GetRole(int.Parse(comboBox.Text.Split(' ')[0]));

                textbox_permission.Text = controller.GetPermission(currentRole.PermissionId).ToString();
                textbox_role.Text = currentRole.RoleName;
            } else {
                button_register.Text = "ADD";

                textbox_permission.Text = "";
                textbox_role.Text = "";
            }
        }

        private void Button_register_Click(object sender, EventArgs e)
        {
            if (button_register.Text.Equals("ADD"))
            {
                currentRole = new Role(controller.GetPermissionId(int.Parse(textbox_permission.Text)), textbox_role.Text);
                controller.AddRole(currentRole);

                MessageBox.Show("Role " + currentRole.RoleName + " added.");

                Update(comboBox.Items.Count);
            } else {
                currentRole = controller.GetRole(int.Parse(comboBox.Text.Split(' ')[0]));
                Role newRole = new Role(controller.GetPermissionId(int.Parse(textbox_permission.Text)), textbox_role.Text);

                if (currentRole.GetDifferences(newRole).Equals(""))
                {
                    MessageBox.Show("Nothing has changed.");
                    return;
                }

                controller.Change(currentRole, newRole);

                MessageBox.Show("Role " + currentRole.RoleName + " has been changed.");

                Update(comboBox.SelectedIndex);
            }
        }

        private void Update(int newIndex)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add("New Role");
            if (controller.HasRoles())
                foreach (string str in controller.GetRolesCombo())
                    comboBox.Items.Add(str);

            comboBox.SelectedIndex = newIndex;
        }

        private void RolesPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Destroy();

            GC.Collect();
        }

        private void Button_back_Click(object sender, EventArgs e)
        {
            NavigateTo((IViewHandler) previousForm);
        }
    }
}
