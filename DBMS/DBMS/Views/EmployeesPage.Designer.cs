namespace DBMS.Views
{
    partial class EmployeesPage
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.button_back = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_role = new System.Windows.Forms.ComboBox();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.main_DatabaseDataSet1 = new DBMS.Main_DatabaseDataSet1();
            this.label8 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.button_register = new System.Windows.Forms.Button();
            this.date_joined = new System.Windows.Forms.DateTimePicker();
            this.date_birth = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            this.main_DatabaseDataSet = new DBMS.Main_DatabaseDataSet();
            this.mainDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDatabaseDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rolesTableAdapter = new DBMS.Main_DatabaseDataSet1TableAdapters.RolesTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_DatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox);
            this.panel1.Controls.Add(this.button_back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1382, 100);
            this.panel1.TabIndex = 4;
            // 
            // comboBox
            // 
            this.comboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(364, 12);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(679, 37);
            this.comboBox.TabIndex = 6;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_back.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_back.FlatAppearance.BorderSize = 0;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Image = global::DBMS.Properties.Resources.back_arrow_white;
            this.button_back.Location = new System.Drawing.Point(12, 12);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(60, 40);
            this.button_back.TabIndex = 5;
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.Button_back_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.comboBox_role);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.button_delete);
            this.panel2.Controls.Add(this.comboBox_gender);
            this.panel2.Controls.Add(this.button_register);
            this.panel2.Controls.Add(this.date_joined);
            this.panel2.Controls.Add(this.date_birth);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textbox_address);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textbox_phone_number);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textbox_email);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textbox_age);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textbox_surname);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textbox_name);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1382, 553);
            this.panel2.TabIndex = 5;
            // 
            // comboBox_role
            // 
            this.comboBox_role.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_role.DataSource = this.rolesBindingSource;
            this.comboBox_role.DisplayMember = "role_name";
            this.comboBox_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox_role.FormattingEnabled = true;
            this.comboBox_role.Location = new System.Drawing.Point(631, 313);
            this.comboBox_role.Name = "comboBox_role";
            this.comboBox_role.Size = new System.Drawing.Size(279, 33);
            this.comboBox_role.TabIndex = 35;
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this.main_DatabaseDataSet1;
            // 
            // main_DatabaseDataSet1
            // 
            this.main_DatabaseDataSet1.DataSetName = "Main_DatabaseDataSet1";
            this.main_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(522, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 26);
            this.label8.TabIndex = 34;
            this.label8.Text = "Role";
            // 
            // button_delete
            // 
            this.button_delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_delete.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_delete.Location = new System.Drawing.Point(582, 479);
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
            this.comboBox_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox_gender.Location = new System.Drawing.Point(327, 140);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(279, 33);
            this.comboBox_gender.TabIndex = 32;
            // 
            // button_register
            // 
            this.button_register.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_register.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_register.FlatAppearance.BorderSize = 0;
            this.button_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_register.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_register.Location = new System.Drawing.Point(582, 410);
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
            this.date_joined.Location = new System.Drawing.Point(956, 244);
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
            this.date_birth.Location = new System.Drawing.Point(327, 244);
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
            this.label13.Location = new System.Drawing.Point(806, 244);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 26);
            this.label13.TabIndex = 24;
            this.label13.Text = "Date Joined";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(156, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 26);
            this.label9.TabIndex = 16;
            this.label9.Text = "Birth Date";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(822, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "Address";
            // 
            // textbox_address
            // 
            this.textbox_address.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textbox_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_address.Location = new System.Drawing.Point(956, 140);
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
            this.label6.Location = new System.Drawing.Point(791, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phone Number";
            // 
            // textbox_phone_number
            // 
            this.textbox_phone_number.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textbox_phone_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_phone_number.Location = new System.Drawing.Point(956, 88);
            this.textbox_phone_number.MaxLength = 13;
            this.textbox_phone_number.Name = "textbox_phone_number";
            this.textbox_phone_number.Size = new System.Drawing.Size(279, 30);
            this.textbox_phone_number.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(842, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // textbox_email
            // 
            this.textbox_email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textbox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_email.Location = new System.Drawing.Point(956, 36);
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
            this.label4.Location = new System.Drawing.Point(182, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Age";
            // 
            // textbox_age
            // 
            this.textbox_age.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textbox_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_age.Location = new System.Drawing.Point(327, 192);
            this.textbox_age.MaxLength = 2;
            this.textbox_age.Name = "textbox_age";
            this.textbox_age.Size = new System.Drawing.Size(279, 30);
            this.textbox_age.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(162, 142);
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
            this.label2.Location = new System.Drawing.Point(156, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // textbox_surname
            // 
            this.textbox_surname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textbox_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_surname.Location = new System.Drawing.Point(327, 88);
            this.textbox_surname.MaxLength = 25;
            this.textbox_surname.Name = "textbox_surname";
            this.textbox_surname.Size = new System.Drawing.Size(279, 30);
            this.textbox_surname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(162, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // textbox_name
            // 
            this.textbox_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textbox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_name.Location = new System.Drawing.Point(327, 36);
            this.textbox_name.MaxLength = 25;
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.Size = new System.Drawing.Size(279, 30);
            this.textbox_name.TabIndex = 1;
            // 
            // main_DatabaseDataSet
            // 
            this.main_DatabaseDataSet.DataSetName = "Main_DatabaseDataSet";
            this.main_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mainDatabaseDataSetBindingSource
            // 
            this.mainDatabaseDataSetBindingSource.DataSource = this.main_DatabaseDataSet;
            this.mainDatabaseDataSetBindingSource.Position = 0;
            // 
            // mainDatabaseDataSetBindingSource1
            // 
            this.mainDatabaseDataSetBindingSource1.DataSource = this.main_DatabaseDataSet;
            this.mainDatabaseDataSetBindingSource1.Position = 0;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1400, 700);
            this.Name = "EmployeesPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeesPage_FormClosing);
            this.Load += new System.EventHandler(this.EmployeesPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_DatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.DateTimePicker date_joined;
        private System.Windows.Forms.DateTimePicker date_birth;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_name;
        private System.Windows.Forms.BindingSource mainDatabaseDataSetBindingSource1;
        private Main_DatabaseDataSet main_DatabaseDataSet;
        private System.Windows.Forms.BindingSource mainDatabaseDataSetBindingSource;
        private Main_DatabaseDataSet1 main_DatabaseDataSet1;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private Main_DatabaseDataSet1TableAdapters.RolesTableAdapter rolesTableAdapter;
        private System.Windows.Forms.ComboBox comboBox_role;
        private System.Windows.Forms.Label label8;
    }
}