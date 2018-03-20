namespace DBMS
{
    partial class LoginPage
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
            System.Windows.Forms.Button button_login;
            this.label_header = new System.Windows.Forms.Label();
            this.textbox_username = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textbox_password = new System.Windows.Forms.TextBox();
            button_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_login
            // 
            button_login.BackColor = System.Drawing.Color.SteelBlue;
            button_login.Cursor = System.Windows.Forms.Cursors.Hand;
            button_login.FlatAppearance.BorderSize = 0;
            button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            button_login.ForeColor = System.Drawing.SystemColors.HighlightText;
            button_login.Location = new System.Drawing.Point(360, 338);
            button_login.Name = "button_login";
            button_login.Size = new System.Drawing.Size(215, 60);
            button_login.TabIndex = 0;
            button_login.Text = "Log In";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += new System.EventHandler(this.Button_login_Click);
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_header.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_header.Location = new System.Drawing.Point(12, 9);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(664, 42);
            this.label_header.TabIndex = 1;
            this.label_header.Text = "Welcome to Gym Management System";
            // 
            // textbox_username
            // 
            this.textbox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_username.Location = new System.Drawing.Point(476, 170);
            this.textbox_username.Name = "textbox_username";
            this.textbox_username.Size = new System.Drawing.Size(200, 30);
            this.textbox_username.TabIndex = 2;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_username.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_username.Location = new System.Drawing.Point(277, 163);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(164, 37);
            this.label_username.TabIndex = 3;
            this.label_username.Text = "Username";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_password.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_password.Location = new System.Drawing.Point(283, 253);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(158, 37);
            this.label_password.TabIndex = 4;
            this.label_password.Text = "Password";
            // 
            // textbox_password
            // 
            this.textbox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_password.Location = new System.Drawing.Point(476, 259);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.Size = new System.Drawing.Size(200, 30);
            this.textbox_password.TabIndex = 5;
            this.textbox_password.TextChanged += new System.EventHandler(this.textbox_password_TextChanged);
            this.textbox_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_password_KeyDown);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.textbox_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.textbox_username);
            this.Controls.Add(this.label_header);
            this.Controls.Add(button_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gym Management System";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_header;
        private System.Windows.Forms.TextBox textbox_username;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textbox_password;
    }
}

