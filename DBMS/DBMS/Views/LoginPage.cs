﻿using System;
using System.Windows.Forms;
using DBMS.Controllers;
using DBMS.Views;
using DBMS.Controllers.DB;

namespace DBMS
{
    public partial class LoginPage : Form, IViewHandler
    {
        private LoginController loginController;

        private Form previousForm;

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
            } else {
                MessageBox.Show("Username or password is incorrect");
            }
        }

        public void Button_login_Click(object sender, EventArgs e) {
            button_login.TabStop = false;

            HandleSubmit();
        }

        public void NavigateTo(IViewHandler form)
        {
            ClearTextBoxes();

            Hide();

            form.Activate(this, loginController.User);
        }

        /// <summary>
        /// Clears the text boxes.
        /// </summary>
        private void ClearTextBoxes()
        {
            textbox_username.Text = "";
            textbox_password.Text = "";
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

        public void Activate(Form sender, User user = null)
        {
            Show();

            previousForm = sender;
        }

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(previousForm != null && !previousForm.IsDisposed)
                previousForm.Dispose();
        }
    }
}