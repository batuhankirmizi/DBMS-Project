﻿using System;
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

        private Form loginPage;

        private Form previousForm;

        private LinkedList<Button> managerButtons = new LinkedList<Button>();
        
        private LinkedList<Button> generalButtons = new LinkedList<Button>();

        public MainPage()
        {
            InitializeComponent();
        }

        public void Activate(Form sender)
        {
            Activate();

            if(sender.Name.Equals("LoginPage")) loginPage = sender;

            user = new User(SSession.username, SSession.name, SSession.isManager);

            if(!label_welcome.Text.Contains(user.Name))
                label_welcome.Text += user.Name;

            previousForm = sender;

            controller = new MainPageController();

            Show();

            controller.Control();

            label_quick_info.Text = "Currently, Gym has:";
            label_quick_info2.Text = "\n";
            AddQuickInfo();
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

            NavigateTo((IViewHandler)loginPage);
        }

        public void Destroy()
        {
            Dispose();
            Close();

            previousForm.Dispose();

            if(!loginPage.IsDisposed)
                loginPage.Dispose();
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
        
        private void AddQuickInfo()
        {
            label_quick_info.Text += "\n" + controller.GetMemberCount() + " Members\n";
            label_quick_info.Text += controller.GetEmployeeCount() + " Employees\n";
            label_quick_info.Text += controller.GetFacilityCount() + " Facilities\n";
            label_quick_info.Text += controller.GetUnpaidPaymentCount() + " Unpaid Payments";

            label_quick_info2.Text += controller.GetCourseCount() + " Courses\n";
            label_quick_info2.Text += controller.GetMembershipsAboutToFinish() + " Memberships less than 10 days to expire\n";
            label_quick_info2.Text += controller.GetEquipmentCount() + " Equipments\n";
            label_quick_info2.Text += controller.GetOutOfWarrantyEquipmentCount() + " Equipments which has expired warranty";
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button_payments_Click(object sender, EventArgs e)
        {
            PaymentsPage payments = new PaymentsPage();

            NavigateTo(payments);
        }

        private void Button_facilities_Click(object sender, EventArgs e)
        {
            FacilitiesPage facilities = new FacilitiesPage();

            NavigateTo(facilities);
        }
    }
}
