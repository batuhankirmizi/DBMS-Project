using System;
using System.Windows.Forms;
using DBMS.Controllers;
using DBMS.Controllers.DB;

namespace DBMS.Views
{
    public partial class MainPage : Form, IViewHandler
    {
        private User user;
        private Form previousForm;

        public MainPage()
        {
            InitializeComponent();
        }

        public void Activate(Form sender, User user)
        {
            previousForm = sender;

            Show();

            this.user = user;
            label_welcome.Text += user.Name;
        }

        public void NavigateTo(IViewHandler form)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            previousForm.Close();
        }
    }
}
