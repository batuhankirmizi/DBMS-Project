using System;
using System.Windows.Forms;
using DBMS.Controllers;
using DBMS.Views;
using DBMS.Controllers.DB;

namespace DBMS
{
    public partial class LoginPage : Form, IViewHandler
    {
        private LoginController loginController;

        public LoginPage()
        {
            InitializeComponent();
        }

        // Initialize local components created by the designer
        private void Init()
        {
            loginController = new LoginController();

            textbox_password.PasswordChar = '\u25CF';
        }

        /// <summary>
        /// The method to be invoked after user pressed submit or enter button.
        /// </summary>
        private void HandleSubmit()
        {
            loginController.Username = textbox_username.Text;
            loginController.Password = textbox_password.Text;

            if (loginController.Control())
            {
                MainPage page = new MainPage();
                NavigateTo(page);
            }
            else
            {
                MessageBox.Show("Username or password is incorrect");
            }
        }

        public void Button_login_Click(object sender, EventArgs e) {
            HandleSubmit();
        }

        public void NavigateTo(IViewHandler form)
        {
            form.Activate(this, loginController.User);
            Hide();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            // Initialize our components
            Init();
        }

        private void textbox_password_TextChanged(object sender, EventArgs e) {}

        private void textbox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.Equals(Keys.Enter))
            {
                HandleSubmit();
            }
        }

        public void Activate(Form sender, User user = null) => throw new NotImplementedException();
    }
}
