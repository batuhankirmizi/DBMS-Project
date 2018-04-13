using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DBMS.Controllers;
using DBMS.Controllers.DB;
using DBMS.Controllers.Interfaces;

namespace DBMS.Views
{
    public partial class MainPage : Form, IViewHandler
    {
        private MainPageController controller;

        private User user;

        private Form previousForm;
        private LoginPage loginPage;

        private LinkedList<Button> managerButtons = new LinkedList<Button>();
        
        private LinkedList<Button> generalButtons = new LinkedList<Button>();

        public MainPage()
        {
            InitializeComponent();
        }

        public void Activate(Form sender)
        {
            Activate();

            if(sender is LoginPage)
                loginPage = (LoginPage) sender;
            previousForm = sender;

            user = new User(SSession.username, SSession.name, SSession.isManager);

            if(!label_welcome.Text.Contains(user.Name))
                label_welcome.Text += user.Name;

            controller = new MainPageController();

            Show();

            controller.Control();
        }

        public void NavigateTo(IViewHandler form)
        {
            Hide();

            form.Activate(this);
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.Logout();

            Destroy();

            GC.Collect();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            // Add manager buttons
            managerButtons.AddLast(button_employees);
            managerButtons.AddLast(button_login_history);
            managerButtons.AddLast(button_permissions);
            managerButtons.AddLast(button_roles);
            managerButtons.AddLast(button_salaries);
            managerButtons.AddLast(button_analytics);

            if (user.Is_manager)
                foreach (Button button in managerButtons)
                    button.Visible = true;

            // Add general buttons
            generalButtons.AddLast(button_back);
            generalButtons.AddLast(button_elapsed_time);
            generalButtons.AddLast(button_members);
            generalButtons.AddLast(button_payments);
            generalButtons.AddLast(button_facilities);
            generalButtons.AddLast(button_member_improvements);
            generalButtons.AddLast(button_memberships);
        }

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);
        }

        private void Button_back_Click(object sender, EventArgs e)
        {
            controller.Logout();

            NavigateTo(loginPage);
        }

        public void Destroy()
        {
            Dispose();
            Close();

            loginPage.Destroy();
            if(previousForm != loginPage && !previousForm.IsDisposed)
                ((IViewHandler)previousForm).Destroy();
        }

        private void Button_elapsed_time_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SSession.GetElapsedTime());
        }

        private void Button_members_Click(object sender, EventArgs e)
        {
            MembersPage members = new MembersPage();

            NavigateTo(members);
        }
    }
}
