namespace DBMS.Views
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_welcome = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_elapsed_time = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_members = new System.Windows.Forms.Button();
            this.button_payments = new System.Windows.Forms.Button();
            this.button_facilities = new System.Windows.Forms.Button();
            this.button_equipments = new System.Windows.Forms.Button();
            this.button_courses = new System.Windows.Forms.Button();
            this.button_member_improvements = new System.Windows.Forms.Button();
            this.button_memberships = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_employees = new System.Windows.Forms.Button();
            this.button_login_history = new System.Windows.Forms.Button();
            this.button_permissions = new System.Windows.Forms.Button();
            this.button_roles = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_salaries = new System.Windows.Forms.Button();
            this.button_analytics = new System.Windows.Forms.Button();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_back = new System.Windows.Forms.Button();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_quick_info = new System.Windows.Forms.Label();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_quick_info2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_welcome.Location = new System.Drawing.Point(72, 4);
            this.label_welcome.Margin = new System.Windows.Forms.Padding(4);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(210, 46);
            this.label_welcome.TabIndex = 0;
            this.label_welcome.Text = "Welcome, ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.76204F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.23796F));
            this.tableLayoutPanel1.Controls.Add(this.button_elapsed_time, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel5, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.21545F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.78455F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1723, 720);
            this.tableLayoutPanel1.TabIndex = 5;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // button_elapsed_time
            // 
            this.button_elapsed_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_elapsed_time.BackColor = System.Drawing.Color.OliveDrab;
            this.button_elapsed_time.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_elapsed_time.FlatAppearance.BorderSize = 0;
            this.button_elapsed_time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_elapsed_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_elapsed_time.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_elapsed_time.Location = new System.Drawing.Point(1578, 676);
            this.button_elapsed_time.Name = "button_elapsed_time";
            this.button_elapsed_time.Size = new System.Drawing.Size(142, 40);
            this.button_elapsed_time.TabIndex = 3;
            this.button_elapsed_time.Text = "Elapsed Time";
            this.button_elapsed_time.UseVisualStyleBackColor = false;
            this.button_elapsed_time.Click += new System.EventHandler(this.Button_elapsed_time_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.button_members);
            this.flowLayoutPanel3.Controls.Add(this.button_payments);
            this.flowLayoutPanel3.Controls.Add(this.button_facilities);
            this.flowLayoutPanel3.Controls.Add(this.button_equipments);
            this.flowLayoutPanel3.Controls.Add(this.button_courses);
            this.flowLayoutPanel3.Controls.Add(this.button_member_improvements);
            this.flowLayoutPanel3.Controls.Add(this.button_memberships);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 240);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1195, 430);
            this.flowLayoutPanel3.TabIndex = 6;
            // 
            // button_members
            // 
            this.button_members.BackColor = System.Drawing.Color.ForestGreen;
            this.button_members.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_members.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_members.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_members.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_members.Image = global::DBMS.Properties.Resources.members;
            this.button_members.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_members.Location = new System.Drawing.Point(3, 3);
            this.button_members.Name = "button_members";
            this.button_members.Size = new System.Drawing.Size(392, 136);
            this.button_members.TabIndex = 0;
            this.button_members.Text = "Members";
            this.button_members.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_members.UseVisualStyleBackColor = false;
            this.button_members.Click += new System.EventHandler(this.Button_members_Click);
            // 
            // button_payments
            // 
            this.button_payments.BackColor = System.Drawing.Color.OliveDrab;
            this.button_payments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_payments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_payments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_payments.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_payments.Image = global::DBMS.Properties.Resources.payments;
            this.button_payments.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_payments.Location = new System.Drawing.Point(401, 3);
            this.button_payments.Name = "button_payments";
            this.button_payments.Size = new System.Drawing.Size(392, 136);
            this.button_payments.TabIndex = 3;
            this.button_payments.Text = "Payments";
            this.button_payments.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_payments.UseVisualStyleBackColor = false;
            this.button_payments.Click += new System.EventHandler(this.Button_payments_Click);
            // 
            // button_facilities
            // 
            this.button_facilities.BackColor = System.Drawing.Color.Teal;
            this.button_facilities.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_facilities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_facilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_facilities.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_facilities.Image = global::DBMS.Properties.Resources.facilities;
            this.button_facilities.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_facilities.Location = new System.Drawing.Point(799, 3);
            this.button_facilities.Name = "button_facilities";
            this.button_facilities.Size = new System.Drawing.Size(392, 136);
            this.button_facilities.TabIndex = 1;
            this.button_facilities.Text = "Facilities";
            this.button_facilities.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_facilities.UseVisualStyleBackColor = false;
            this.button_facilities.Click += new System.EventHandler(this.Button_facilities_Click);
            // 
            // button_equipments
            // 
            this.button_equipments.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_equipments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_equipments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_equipments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_equipments.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_equipments.Image = global::DBMS.Properties.Resources.equipments;
            this.button_equipments.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_equipments.Location = new System.Drawing.Point(3, 145);
            this.button_equipments.Name = "button_equipments";
            this.button_equipments.Size = new System.Drawing.Size(392, 136);
            this.button_equipments.TabIndex = 2;
            this.button_equipments.Text = "Equipments";
            this.button_equipments.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_equipments.UseVisualStyleBackColor = false;
            this.button_equipments.Click += new System.EventHandler(this.Button_equipments_Click);
            // 
            // button_courses
            // 
            this.button_courses.BackColor = System.Drawing.Color.Goldenrod;
            this.button_courses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_courses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_courses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_courses.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_courses.Image = global::DBMS.Properties.Resources.courses;
            this.button_courses.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_courses.Location = new System.Drawing.Point(401, 145);
            this.button_courses.Name = "button_courses";
            this.button_courses.Size = new System.Drawing.Size(392, 136);
            this.button_courses.TabIndex = 4;
            this.button_courses.Text = "Courses";
            this.button_courses.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_courses.UseVisualStyleBackColor = false;
            // 
            // button_member_improvements
            // 
            this.button_member_improvements.BackColor = System.Drawing.Color.BlueViolet;
            this.button_member_improvements.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_member_improvements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_member_improvements.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_member_improvements.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_member_improvements.Image = global::DBMS.Properties.Resources.member_improvements;
            this.button_member_improvements.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_member_improvements.Location = new System.Drawing.Point(799, 145);
            this.button_member_improvements.Name = "button_member_improvements";
            this.button_member_improvements.Size = new System.Drawing.Size(392, 136);
            this.button_member_improvements.TabIndex = 5;
            this.button_member_improvements.Text = "Member Improvements";
            this.button_member_improvements.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_member_improvements.UseVisualStyleBackColor = false;
            // 
            // button_memberships
            // 
            this.button_memberships.BackColor = System.Drawing.Color.Orchid;
            this.button_memberships.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_memberships.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_memberships.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_memberships.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_memberships.Image = global::DBMS.Properties.Resources.memberships;
            this.button_memberships.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_memberships.Location = new System.Drawing.Point(3, 287);
            this.button_memberships.Name = "button_memberships";
            this.button_memberships.Size = new System.Drawing.Size(392, 136);
            this.button_memberships.TabIndex = 6;
            this.button_memberships.Text = "Memberships";
            this.button_memberships.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_memberships.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel2.Controls.Add(this.button_employees);
            this.flowLayoutPanel2.Controls.Add(this.button_login_history);
            this.flowLayoutPanel2.Controls.Add(this.button_permissions);
            this.flowLayoutPanel2.Controls.Add(this.button_roles);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1205, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(514, 231);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // button_employees
            // 
            this.button_employees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_employees.BackColor = System.Drawing.Color.Brown;
            this.button_employees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_employees.FlatAppearance.BorderSize = 0;
            this.button_employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_employees.ForeColor = System.Drawing.SystemColors.Control;
            this.button_employees.Image = global::DBMS.Properties.Resources.employees;
            this.button_employees.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_employees.Location = new System.Drawing.Point(3, 3);
            this.button_employees.Name = "button_employees";
            this.button_employees.Size = new System.Drawing.Size(250, 110);
            this.button_employees.TabIndex = 4;
            this.button_employees.Text = "Employees";
            this.button_employees.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_employees.UseVisualStyleBackColor = false;
            this.button_employees.Visible = false;
            // 
            // button_login_history
            // 
            this.button_login_history.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_login_history.BackColor = System.Drawing.Color.Brown;
            this.button_login_history.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_login_history.FlatAppearance.BorderSize = 0;
            this.button_login_history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_login_history.ForeColor = System.Drawing.SystemColors.Control;
            this.button_login_history.Image = global::DBMS.Properties.Resources.login_history;
            this.button_login_history.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_login_history.Location = new System.Drawing.Point(259, 3);
            this.button_login_history.Name = "button_login_history";
            this.button_login_history.Size = new System.Drawing.Size(250, 110);
            this.button_login_history.TabIndex = 5;
            this.button_login_history.Text = "Login History";
            this.button_login_history.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_login_history.UseVisualStyleBackColor = false;
            this.button_login_history.Visible = false;
            this.button_login_history.Click += new System.EventHandler(this.Button_login_history_Click);
            // 
            // button_permissions
            // 
            this.button_permissions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_permissions.BackColor = System.Drawing.Color.Brown;
            this.button_permissions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_permissions.FlatAppearance.BorderSize = 0;
            this.button_permissions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_permissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_permissions.ForeColor = System.Drawing.SystemColors.Control;
            this.button_permissions.Image = global::DBMS.Properties.Resources.permissions;
            this.button_permissions.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_permissions.Location = new System.Drawing.Point(3, 119);
            this.button_permissions.Name = "button_permissions";
            this.button_permissions.Size = new System.Drawing.Size(250, 110);
            this.button_permissions.TabIndex = 6;
            this.button_permissions.Text = "Permissions";
            this.button_permissions.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_permissions.UseVisualStyleBackColor = false;
            this.button_permissions.Visible = false;
            // 
            // button_roles
            // 
            this.button_roles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_roles.BackColor = System.Drawing.Color.Brown;
            this.button_roles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_roles.FlatAppearance.BorderSize = 0;
            this.button_roles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_roles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_roles.ForeColor = System.Drawing.SystemColors.Control;
            this.button_roles.Image = global::DBMS.Properties.Resources.roles;
            this.button_roles.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_roles.Location = new System.Drawing.Point(259, 119);
            this.button_roles.Name = "button_roles";
            this.button_roles.Size = new System.Drawing.Size(250, 110);
            this.button_roles.TabIndex = 7;
            this.button_roles.Text = "Roles";
            this.button_roles.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_roles.UseVisualStyleBackColor = false;
            this.button_roles.Visible = false;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel4.Controls.Add(this.button_salaries);
            this.flowLayoutPanel4.Controls.Add(this.button_analytics);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(1204, 240);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(516, 430);
            this.flowLayoutPanel4.TabIndex = 8;
            // 
            // button_salaries
            // 
            this.button_salaries.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_salaries.AutoSize = true;
            this.button_salaries.BackColor = System.Drawing.Color.Brown;
            this.button_salaries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_salaries.FlatAppearance.BorderSize = 0;
            this.button_salaries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_salaries.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_salaries.ForeColor = System.Drawing.SystemColors.Control;
            this.button_salaries.Image = global::DBMS.Properties.Resources.salaries;
            this.button_salaries.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_salaries.Location = new System.Drawing.Point(3, 3);
            this.button_salaries.Name = "button_salaries";
            this.button_salaries.Size = new System.Drawing.Size(506, 115);
            this.button_salaries.TabIndex = 7;
            this.button_salaries.Text = "Salaries";
            this.button_salaries.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_salaries.UseVisualStyleBackColor = false;
            this.button_salaries.Visible = false;
            // 
            // button_analytics
            // 
            this.button_analytics.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_analytics.AutoSize = true;
            this.button_analytics.BackColor = System.Drawing.Color.Brown;
            this.button_analytics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_analytics.FlatAppearance.BorderSize = 0;
            this.button_analytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_analytics.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_analytics.ForeColor = System.Drawing.SystemColors.Control;
            this.button_analytics.Image = global::DBMS.Properties.Resources.analytics;
            this.button_analytics.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_analytics.Location = new System.Drawing.Point(3, 124);
            this.button_analytics.Name = "button_analytics";
            this.button_analytics.Size = new System.Drawing.Size(506, 115);
            this.button_analytics.TabIndex = 8;
            this.button_analytics.Text = "Analytics";
            this.button_analytics.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_analytics.UseVisualStyleBackColor = false;
            this.button_analytics.Visible = false;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(1195, 231);
            this.flowLayoutPanel5.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button_back);
            this.flowLayoutPanel1.Controls.Add(this.label_welcome);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1188, 50);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_back.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_back.FlatAppearance.BorderSize = 0;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Image = global::DBMS.Properties.Resources.back_arrow_white;
            this.button_back.Location = new System.Drawing.Point(4, 4);
            this.button_back.Margin = new System.Windows.Forms.Padding(4);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(60, 40);
            this.button_back.TabIndex = 2;
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.Button_back_Click);
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.label_quick_info);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 59);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(599, 170);
            this.flowLayoutPanel6.TabIndex = 7;
            // 
            // label_quick_info
            // 
            this.label_quick_info.AutoSize = true;
            this.label_quick_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_quick_info.Location = new System.Drawing.Point(8, 8);
            this.label_quick_info.Margin = new System.Windows.Forms.Padding(8);
            this.label_quick_info.Name = "label_quick_info";
            this.label_quick_info.Size = new System.Drawing.Size(256, 31);
            this.label_quick_info.TabIndex = 0;
            this.label_quick_info.Text = "Currently, Gym has:";
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.label_quick_info2);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(608, 59);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(583, 170);
            this.flowLayoutPanel7.TabIndex = 8;
            // 
            // label_quick_info2
            // 
            this.label_quick_info2.AutoSize = true;
            this.label_quick_info2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_quick_info2.Location = new System.Drawing.Point(8, 8);
            this.label_quick_info2.Margin = new System.Windows.Forms.Padding(8);
            this.label_quick_info2.Name = "label_quick_info2";
            this.label_quick_info2.Size = new System.Drawing.Size(256, 31);
            this.label_quick_info2.TabIndex = 0;
            this.label_quick_info2.Text = "Currently, Gym has:";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1723, 720);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gym Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPage_FormClosing);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button button_members;
        private System.Windows.Forms.Button button_elapsed_time;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button_employees;
        private System.Windows.Forms.Button button_login_history;
        private System.Windows.Forms.Button button_facilities;
        private System.Windows.Forms.Button button_equipments;
        private System.Windows.Forms.Button button_permissions;
        private System.Windows.Forms.Button button_payments;
        private System.Windows.Forms.Button button_courses;
        private System.Windows.Forms.Button button_roles;
        private System.Windows.Forms.Button button_member_improvements;
        private System.Windows.Forms.Button button_memberships;
        private System.Windows.Forms.Button button_salaries;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button button_analytics;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        protected System.Windows.Forms.Label label_quick_info;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label label_quick_info2;
    }
}