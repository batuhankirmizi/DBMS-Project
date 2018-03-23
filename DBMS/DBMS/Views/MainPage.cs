using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DBMS.Controllers;
using DBMS.Controllers.DB;

namespace DBMS.Views
{
    public partial class MainPage : Form, IViewHandler
    {
        private MainPageController controller;

        private User user;

        private Form previousForm;

        private LinkedList<Button> managerButtons = new LinkedList<Button>();
        
        private LinkedList<Button> generalButtons = new LinkedList<Button>();

        public MainPage()
        {
            InitializeComponent();
        }

        public void Activate(Form sender)
        {
            previousForm = sender;

            user = new User(SSession.username, SSession.name, SSession.isManager);

            label_welcome.Text += user.Name;

            controller = new MainPageController();

            Show();
        }

        public void NavigateTo(IViewHandler form)
        {
            Hide();

            form.Activate(this);
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.Logout();

            if(previousForm != null && !previousForm.IsDisposed)
                previousForm.Dispose();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            // Make the form non-resizable and maximized
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;

            // Add manager buttons
            managerButtons.AddLast(button_add_employee);
            managerButtons.AddLast(button_edit_employees);

            if (user.Is_manager)
            {
                foreach (Button button in managerButtons)
                {
                    button.Visible = true;
                }
            }

            // Add general buttons
            generalButtons.AddLast(button_back);
            generalButtons.AddLast(button_elapsed_time);
        }

        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            controller.Logout();

            NavigateTo((IViewHandler) previousForm);
        }

        private void button_add_employee_Click(object sender, EventArgs e)
        {

        }

        private void button_elapsed_time_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SSession.GetElapsedTime());
        }
    }
}
