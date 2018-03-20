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
            this.button_add_employee = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_welcome.Location = new System.Drawing.Point(78, 14);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(210, 46);
            this.label_welcome.TabIndex = 0;
            this.label_welcome.Text = "Welcome, ";
            // 
            // button_add_employee
            // 
            this.button_add_employee.BackColor = System.Drawing.Color.Gray;
            this.button_add_employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add_employee.FlatAppearance.BorderSize = 0;
            this.button_add_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_add_employee.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_add_employee.Location = new System.Drawing.Point(1508, 12);
            this.button_add_employee.Name = "button_add_employee";
            this.button_add_employee.Size = new System.Drawing.Size(250, 60);
            this.button_add_employee.TabIndex = 1;
            this.button_add_employee.Text = "Add Employee";
            this.button_add_employee.UseVisualStyleBackColor = false;
            this.button_add_employee.Visible = false;
            this.button_add_employee.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_back
            // 
            this.button_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_back.Location = new System.Drawing.Point(12, 12);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(60, 48);
            this.button_back.TabIndex = 2;
            this.button_back.Text = "BACK";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1770, 737);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_add_employee);
            this.Controls.Add(this.label_welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
    }
}