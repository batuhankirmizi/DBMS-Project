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
            this.button_elapsed_time = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.button_add_employee = new System.Windows.Forms.Button();
            this.button_edit_employees = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_welcome.Location = new System.Drawing.Point(78, 9);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(210, 46);
            this.label_welcome.TabIndex = 0;
            this.label_welcome.Text = "Welcome, ";
            // 
            // button_elapsed_time
            // 
            this.button_elapsed_time.Location = new System.Drawing.Point(12, 976);
            this.button_elapsed_time.Name = "button_elapsed_time";
            this.button_elapsed_time.Size = new System.Drawing.Size(145, 41);
            this.button_elapsed_time.TabIndex = 3;
            this.button_elapsed_time.Text = "Elapsed Time";
            this.button_elapsed_time.UseVisualStyleBackColor = true;
            this.button_elapsed_time.Click += new System.EventHandler(this.button_elapsed_time_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_back.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_back.FlatAppearance.BorderSize = 0;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Image = global::DBMS.Properties.Resources.back_arrow_white;
            this.button_back.Location = new System.Drawing.Point(12, 9);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(60, 40);
            this.button_back.TabIndex = 2;
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_add_employee
            // 
            this.button_add_employee.BackColor = System.Drawing.Color.DarkRed;
            this.button_add_employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add_employee.FlatAppearance.BorderSize = 0;
            this.button_add_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_add_employee.ForeColor = System.Drawing.SystemColors.Control;
            this.button_add_employee.Image = global::DBMS.Properties.Resources.add_employee;
            this.button_add_employee.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_add_employee.Location = new System.Drawing.Point(1636, 12);
            this.button_add_employee.Name = "button_add_employee";
            this.button_add_employee.Size = new System.Drawing.Size(250, 110);
            this.button_add_employee.TabIndex = 1;
            this.button_add_employee.Text = "Add Employee";
            this.button_add_employee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_add_employee.UseVisualStyleBackColor = true;
            this.button_add_employee.Visible = false;
            this.button_add_employee.Click += new System.EventHandler(this.button_add_employee_Click);
            // 
            // button_edit_employees
            // 
            this.button_edit_employees.BackColor = System.Drawing.Color.DarkRed;
            this.button_edit_employees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_edit_employees.FlatAppearance.BorderSize = 0;
            this.button_edit_employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit_employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_edit_employees.ForeColor = System.Drawing.SystemColors.Control;
            this.button_edit_employees.Image = global::DBMS.Properties.Resources.edit_employees;
            this.button_edit_employees.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_edit_employees.Location = new System.Drawing.Point(1380, 12);
            this.button_edit_employees.Name = "button_edit_employees";
            this.button_edit_employees.Size = new System.Drawing.Size(250, 110);
            this.button_edit_employees.TabIndex = 4;
            this.button_edit_employees.Text = "Edit Employees";
            this.button_edit_employees.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_edit_employees.UseVisualStyleBackColor = true;
            this.button_edit_employees.Visible = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1898, 1029);
            this.Controls.Add(this.button_edit_employees);
            this.Controls.Add(this.button_elapsed_time);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_add_employee);
            this.Controls.Add(this.label_welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gym Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPage_FormClosing);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Button button_add_employee;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_elapsed_time;
        private System.Windows.Forms.Button button_edit_employees;
    }
}