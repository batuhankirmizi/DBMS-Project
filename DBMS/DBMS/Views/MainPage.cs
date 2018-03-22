using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DBMS.Controllers;
using DBMS.Controllers.DB;

namespace DBMS.Views
{
    public partial class MainPage : Form, IViewHandler
    {
        private User user;

        private Form previousForm;

        private LinkedList<Button> managerButtons = new LinkedList<Button>();

        public MainPage()
        {
            InitializeComponent();
        }

        public void Activate(Form sender)
        {
            previousForm = sender;
            
            user = new User(SSession.username, SSession.name, SSession.isManager);

            label_welcome.Text += user.Name;

            Show();
        }

        public void NavigateTo(IViewHandler form)
        {
            Hide();

            form.Activate(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(previousForm != null && !previousForm.IsDisposed)
                previousForm.Dispose();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            managerButtons.AddLast(button_add_employee);

            if (user.Is_manager)
            {
                foreach (Button button in managerButtons)
                {
                    button.Visible = true;
                }
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            SSession.End();

            NavigateTo((IViewHandler) previousForm);
        }
    }
}
