using System;
using System.Windows.Forms;
using DBMS.Controllers;

namespace DBMS
{
    public partial class form_login : Form
    {
        LoginController loginController;

        public form_login()
        {
            InitializeComponent();
            
            // Initialize our components
            Init();
        }

        // Initialize local components created by the designer
        private void Init()
        {
            loginController = new LoginController(IDBStatics.Login);

            textbox_password.PasswordChar = '\u25CF';
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            loginController.Control();
        }
    }
}
