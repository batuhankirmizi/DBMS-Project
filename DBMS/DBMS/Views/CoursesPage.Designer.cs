namespace DBMS.Views
{
    partial class Courses
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.button_back = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_active = new System.Windows.Forms.ComboBox();
            this.textBox_day = new System.Windows.Forms.TextBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_course_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.main_DatabaseDataSet2 = new DBMS.Main_DatabaseDataSet2();
            this.textBox_trainer = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_DatabaseDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox);
            this.panel1.Controls.Add(this.button_back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 100);
            this.panel1.TabIndex = 2;
            // 
            // comboBox
            // 
            this.comboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(164, 12);
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
            this.panel2.Controls.Add(this.comboBox_active);
            this.panel2.Controls.Add(this.textBox_day);
            this.panel2.Controls.Add(this.button_delete);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox_description);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button_add);
            this.panel2.Controls.Add(this.textBox_trainer);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox_course_name);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 566);
            this.panel2.TabIndex = 3;
            // 
            // comboBox_active
            // 
            this.comboBox_active.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_active.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_active.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_active.FormattingEnabled = true;
            this.comboBox_active.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBox_active.Location = new System.Drawing.Point(393, 276);
            this.comboBox_active.Name = "comboBox_active";
            this.comboBox_active.Size = new System.Drawing.Size(345, 33);
            this.comboBox_active.TabIndex = 30;
            // 
            // textBox_day
            // 
            this.textBox_day.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_day.Location = new System.Drawing.Point(393, 218);
            this.textBox_day.MaxLength = 25;
            this.textBox_day.Name = "textBox_day";
            this.textBox_day.Size = new System.Drawing.Size(345, 30);
            this.textBox_day.TabIndex = 29;
            // 
            // button_delete
            // 
            this.button_delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_delete.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(292, 437);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(158, 71);
            this.button_delete.TabIndex = 28;
            this.button_delete.Text = "DELETE";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Visible = false;
            this.button_delete.Click += new System.EventHandler(this.Button_delete_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(183, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Active";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(193, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Day";
            // 
            // textBox_description
            // 
            this.textBox_description.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_description.Location = new System.Drawing.Point(393, 160);
            this.textBox_description.MaxLength = 100;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(345, 30);
            this.textBox_description.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(159, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Description";
            // 
            // button_add
            // 
            this.button_add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_add.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(292, 360);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(158, 71);
            this.button_add.TabIndex = 9;
            this.button_add.Text = "ADD";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(183, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Trainer";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // textBox_course_name
            // 
            this.textBox_course_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_course_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_course_name.Location = new System.Drawing.Point(393, 42);
            this.textBox_course_name.MaxLength = 80;
            this.textBox_course_name.Name = "textBox_course_name";
            this.textBox_course_name.Size = new System.Drawing.Size(345, 30);
            this.textBox_course_name.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(159, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Course Name";
            // 
            // main_DatabaseDataSet2
            // 
            this.main_DatabaseDataSet2.DataSetName = "Main_DatabaseDataSet2";
            this.main_DatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox_trainer
            // 
            this.textBox_trainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_trainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_trainer.Location = new System.Drawing.Point(393, 104);
            this.textBox_trainer.MaxLength = 25;
            this.textBox_trainer.Name = "textBox_trainer";
            this.textBox_trainer.Size = new System.Drawing.Size(345, 30);
            this.textBox_trainer.TabIndex = 8;
            this.textBox_trainer.TextChanged += new System.EventHandler(this.TextBox_trainer_TextChanged);
            // 
            // Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 678);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Courses";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Courses";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CoursesPage_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_DatabaseDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_course_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_day;
        private System.Windows.Forms.ComboBox comboBox_active;
        private Main_DatabaseDataSet2 main_DatabaseDataSet2;
        private System.Windows.Forms.TextBox textBox_trainer;
    }
}