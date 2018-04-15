using System;
using System.Windows.Forms;
using DBMS.Controllers.Interfaces;

namespace DBMS.Views
{
    public partial class LoginHistoryPage : Form, IViewHandler
    {
        private Form previousForm;

        public LoginHistoryPage()
        {
            InitializeComponent();
        }

        public void Activate(Form sender)
        {
            Activate();

            previousForm = sender;

            Show();
        }

        public void Destroy()
        {
            dataGridView1.Dispose();

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

        private void LoginHistoryPage_Load(object sender, EventArgs e)
        {
            login_HistoryTableAdapter.Fill(administrationDataSet.Login_History);
        }

        private void HandleSubmit()
        {
            NavigateTo((IViewHandler) previousForm);
        }

        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape))
            {
                HandleSubmit();
            }
        }

        private void LoginHistoryPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Destroy();

            GC.Collect();
        }

        private void LoginHistoryPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape))
            {
                HandleSubmit();
            }
        }
    }
}
