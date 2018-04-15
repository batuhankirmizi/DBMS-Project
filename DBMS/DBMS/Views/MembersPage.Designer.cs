namespace DBMS.Views
{
    partial class MembersPage
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
            this.membersTableAdapter = new DBMS.Main_DatabaseDataSetTableAdapters.MembersTableAdapter();
            this.button_back = new System.Windows.Forms.Button();
            this.combo_box = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_delete = new System.Windows.Forms.Button();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textbox_permission_level = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textbox_monthly_payment = new System.Windows.Forms.TextBox();
            this.button_register = new System.Windows.Forms.Button();
            this.date_joined = new System.Windows.Forms.DateTimePicker();
            this.date_birth = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textbox_weight = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textbox_weekly_entrance_right = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textbox_mem_duration = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textbox_height = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textbox_address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textbox_phone_number = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textbox_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox_age = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_surname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_name = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_back.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_back.FlatAppearance.BorderSize = 0;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Image = global::DBMS.Properties.Resources.back_arrow_white;
            this.button_back.Location = new System.Drawing.Point(9, 9);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(60, 40);
            this.button_back.TabIndex = 3;
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.Button_back_Click);
            // 
            // combo_box
            // 
            this.combo_box.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combo_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.combo_box.FormattingEnabled = true;
            this.combo_box.Location = new System.Drawing.Point(407, 12);
            this.combo_box.Name = "combo_box";
            this.combo_box.Size = new System.Drawing.Size(743, 37);
            this.combo_box.TabIndex = 4;
            this.combo_box.SelectedIndexChanged += new System.EventHandler(this.Combo_box_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.35693F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.64307F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1525, 753);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.comboBox_gender);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.textbox_permission_level);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.textbox_monthly_payment);
            this.panel1.Controls.Add(this.button_register);
            this.panel1.Controls.Add(this.date_joined);
            this.panel1.Controls.Add(this.date_birth);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.textbox_weight);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.textbox_weekly_entrance_right);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textbox_mem_duration);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textbox_height);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textbox_address);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textbox_phone_number);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textbox_email);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textbox_age);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textbox_surname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textbox_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1519, 662);
            this.panel1.TabIndex = 2;
            // 
            // button_delete
            // 
            this.button_delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_delete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_delete.Location = new System.Drawing.Point(653, 571);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(244, 63);
            this.button_delete.TabIndex = 33;
            this.button_delete.Text = "DELETE";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Visible = false;
            this.button_delete.Click += new System.EventHandler(this.Button_delete_Click);
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_gender.DisplayMember = "Male";
            this.comboBox_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox_gender.Location = new System.Drawing.Point(395, 140);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(279, 33);
            this.comboBox_gender.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(821, 398);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(179, 26);
            this.label15.TabIndex = 30;
            this.label15.Text = "Permission Level";
            // 
            // textbox_permission_level
            // 
            this.textbox_permission_level.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textbox_permission_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_permission_level.Location = new System.Drawing.Point(1024, 398);
            this.textbox_permission_level.MaxLength = 2;
            this.textbox_permission_level.Name = "textbox_permission_level";
            this.textbox_permission_level.Size = new System.Drawing.Size(279, 30);
            this.textbox_permission_level.TabIndex = 31;
            this.textbox_permission_level.TextChanged += new System.EventHandler(this.Textbox_permission_level_TextChanged);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(169, 400);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(181, 26);
            this.label14.TabIndex = 28;
            this.label14.Text = "Monthly Payment";
            // 
            // textbox_monthly_payment
            // 
            this.textbox_monthly_payment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textbox_monthly_payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_monthly_payment.Location = new System.Drawing.Point(395, 400);
            this.textbox_monthly_payment.MaxLength = 6;
            this.textbox_monthly_payment.Name = "textbox_monthly_payment";
            this.textbox_monthly_payment.Size = new System.Drawing.Size(279, 30);
            this.textbox_monthly_payment.TabIndex = 29;
            this.textbox_monthly_payment.TextChanged += new System.EventHandler(this.Textbox_monthly_payment_TextChanged);
            // 
            // button_register
            // 
            this.button_register.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_register.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_register.FlatAppearance.BorderSize = 0;
            this.button_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_register.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_register.Location = new System.Drawing.Point(653, 502);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(244, 63);
            this.button_register.TabIndex = 27;
            this.button_register.Text = "REGISTER";
            this.button_register.UseVisualStyleBackColor = false;
            this.button_register.Click += new System.EventHandler(this.Button_register_Click);
            // 
            // date_joined
            // 
            this.date_joined.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.date_joined.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date_joined.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date_joined.Location = new System.Drawing.Point(1024, 348);
            this.date_joined.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.date_joined.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.date_joined.Name = "date_joined";
            this.date_joined.Size = new System.Drawing.Size(279, 30);
            this.date_joined.TabIndex = 26;
            // 
            // date_birth
            // 
            this.date_birth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.date_birth.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date_birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date_birth.Location = new System.Drawing.Point(395, 244);
            this.date_birth.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.date_birth.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.date_birth.Name = "date_birth";
            this.date_birth.Size = new System.Drawing.Size(279, 30);
            this.date_birth.TabIndex = 26;
            this.date_birth.Value = new System.DateTime(2015, 12, 31, 0, 0, 0, 0);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(874, 348);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 26);
            this.label13.TabIndex = 24;
            this.label13.Text = "Date Joined";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(903, 296);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 26);
            this.label12.TabIndex = 22;
            this.label12.Text = "Weight";
            // 
            // textbox_weight
            // 
            this.textbox_weight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textbox_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_weight.Location = new System.Drawing.Point(1024, 296);
            this.textbox_weight.MaxLength = 3;
            this.textbox_weight.Name = "textbox_weight";
            this.textbox_weight.Size = new System.Drawing.Size(279, 30);
            this.textbox_weight.TabIndex = 23;
            this.textbox_weight.TextChanged += new System.EventHandler(this.Textbox_weight_TextChanged);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(141, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(234, 26);
            this.label11.TabIndex = 20;
            this.label11.Text = "Weekly Entrance Right";
            // 
            // textbox_weekly_entrance_right
            // 
            this.textbox_weekly_entrance_right.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textbox_weekly_entrance_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_weekly_entrance_right.Location = new System.Drawing.Point(395, 348);
            this.textbox_weekly_entrance_right.MaxLength = 1;
            this.textbox_weekly_entrance_right.Name = "textbox_weekly_entrance_right";
            this.textbox_weekly_entrance_right.Size = new System.Drawing.Size(279, 30);
            this.textbox_weekly_entrance_right.TabIndex = 21;
            this.textbox_weekly_entrance_right.TextChanged += new System.EventHandler(this.Textbox_weekly_entrance_right_TextChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(155, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(220, 26);
            this.label10.TabIndex = 18;
            this.label10.Text = "Membership Duration";
            // 
            // textbox_mem_duration
            // 
            this.textbox_mem_duration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textbox_mem_duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_mem_duration.Location = new System.Drawing.Point(395, 296);
            this.textbox_mem_duration.MaxLength = 2;
            this.textbox_mem_duration.Name = "textbox_mem_duration";
            this.textbox_mem_duration.Size = new System.Drawing.Size(279, 30);
            this.textbox_mem_duration.TabIndex = 19;
            this.textbox_mem_duration.TextChanged += new System.EventHandler(this.Textbox_mem_duration_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(216, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 26);
            this.label9.TabIndex = 16;
            this.label9.Text = "Birth Date";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(903, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 26);
            this.label8.TabIndex = 14;
            this.label8.Text = "Height";
            // 
            // textbox_height
            // 
            this.textbox_height.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textbox_height.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_height.Location = new System.Drawing.Point(1024, 244);
            this.textbox_height.MaxLength = 3;
            this.textbox_height.Name = "textbox_height";
            this.textbox_height.Size = new System.Drawing.Size(279, 30);
            this.textbox_height.TabIndex = 15;
            this.textbox_height.TextChanged += new System.EventHandler(this.Textbox_height_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(890, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "Address";
            // 
            // textbox_address
            // 
            this.textbox_address.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textbox_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_address.Location = new System.Drawing.Point(1024, 140);
            this.textbox_address.MaxLength = 160;
            this.textbox_address.Multiline = true;
            this.textbox_address.Name = "textbox_address";
            this.textbox_address.Size = new System.Drawing.Size(279, 94);
            this.textbox_address.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(859, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phone Number";
            // 
            // textbox_phone_number
            // 
            this.textbox_phone_number.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textbox_phone_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_phone_number.Location = new System.Drawing.Point(1024, 88);
            this.textbox_phone_number.MaxLength = 13;
            this.textbox_phone_number.Name = "textbox_phone_number";
            this.textbox_phone_number.Size = new System.Drawing.Size(279, 30);
            this.textbox_phone_number.TabIndex = 11;
            this.textbox_phone_number.TextChanged += new System.EventHandler(this.Textbox_phone_number_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(910, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // textbox_email
            // 
            this.textbox_email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textbox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_email.Location = new System.Drawing.Point(1024, 36);
            this.textbox_email.MaxLength = 75;
            this.textbox_email.Name = "textbox_email";
            this.textbox_email.Size = new System.Drawing.Size(279, 30);
            this.textbox_email.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(241, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Age";
            // 
            // textbox_age
            // 
            this.textbox_age.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textbox_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_age.Location = new System.Drawing.Point(395, 192);
            this.textbox_age.MaxLength = 2;
            this.textbox_age.Name = "textbox_age";
            this.textbox_age.Size = new System.Drawing.Size(279, 30);
            this.textbox_age.TabIndex = 7;
            this.textbox_age.TextChanged += new System.EventHandler(this.Textbox_age_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(230, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(224, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // textbox_surname
            // 
            this.textbox_surname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textbox_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_surname.Location = new System.Drawing.Point(395, 88);
            this.textbox_surname.MaxLength = 25;
            this.textbox_surname.Name = "textbox_surname";
            this.textbox_surname.Size = new System.Drawing.Size(279, 30);
            this.textbox_surname.TabIndex = 3;
            this.textbox_surname.TextChanged += new System.EventHandler(this.Textbox_surname_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(230, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // textbox_name
            // 
            this.textbox_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textbox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_name.Location = new System.Drawing.Point(395, 36);
            this.textbox_name.MaxLength = 25;
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.Size = new System.Drawing.Size(279, 30);
            this.textbox_name.TabIndex = 1;
            this.textbox_name.TextChanged += new System.EventHandler(this.Textbox_name_TextChanged);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.button_back);
            this.panel2.Controls.Add(this.combo_box);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1519, 79);
            this.panel2.TabIndex = 3;
            // 
            // MembersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 753);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1250, 700);
            this.Name = "MembersPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Members";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Members_FormClosing);
            this.Load += new System.EventHandler(this.MembersPage_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Main_DatabaseDataSetTableAdapters.MembersTableAdapter membersTableAdapter;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.ComboBox combo_box;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textbox_height;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textbox_address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbox_phone_number;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbox_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textbox_age;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_surname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textbox_weight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textbox_weekly_entrance_right;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textbox_mem_duration;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker date_birth;
        private System.Windows.Forms.DateTimePicker date_joined;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textbox_permission_level;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textbox_monthly_payment;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.Button button_delete;
    }
}