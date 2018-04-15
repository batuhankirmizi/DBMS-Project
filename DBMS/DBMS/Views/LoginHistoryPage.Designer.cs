namespace DBMS.Views
{
    partial class LoginHistoryPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.administrationDataSet = new DBMS.AdministrationDataSet();
            this.administrationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.administrationDataSet1 = new DBMS.AdministrationDataSet();
            this.loginHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.login_HistoryTableAdapter = new DBMS.AdministrationDataSetTableAdapters.Login_HistoryTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logdetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.administrationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrationDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrationDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // administrationDataSet
            // 
            this.administrationDataSet.DataSetName = "AdministrationDataSet";
            this.administrationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // administrationDataSetBindingSource
            // 
            this.administrationDataSetBindingSource.DataSource = this.administrationDataSet;
            this.administrationDataSetBindingSource.Position = 0;
            // 
            // administrationDataSet1
            // 
            this.administrationDataSet1.DataSetName = "AdministrationDataSet";
            this.administrationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginHistoryBindingSource
            // 
            this.loginHistoryBindingSource.DataMember = "Login History";
            this.loginHistoryBindingSource.DataSource = this.administrationDataSetBindingSource;
            // 
            // login_HistoryTableAdapter
            // 
            this.login_HistoryTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.logdetailsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loginHistoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1500, 691);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView1_KeyDown);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8);
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.idDataGridViewTextBoxColumn.HeaderText = "Attempt Number";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 250;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8);
            this.usernameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Width = 102;
            // 
            // logdetailsDataGridViewTextBoxColumn
            // 
            this.logdetailsDataGridViewTextBoxColumn.DataPropertyName = "log_details";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(8);
            this.logdetailsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.logdetailsDataGridViewTextBoxColumn.HeaderText = "Details";
            this.logdetailsDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.logdetailsDataGridViewTextBoxColumn.Name = "logdetailsDataGridViewTextBoxColumn";
            this.logdetailsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LoginHistoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 692);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LoginHistoryPage";
            this.ShowIcon = false;
            this.Text = "Login History";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginHistoryPage_FormClosing);
            this.Load += new System.EventHandler(this.LoginHistoryPage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginHistoryPage_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.administrationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrationDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrationDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource administrationDataSetBindingSource;
        private AdministrationDataSet administrationDataSet;
        private AdministrationDataSet administrationDataSet1;
        private System.Windows.Forms.BindingSource loginHistoryBindingSource;
        private AdministrationDataSetTableAdapters.Login_HistoryTableAdapter login_HistoryTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logdetailsDataGridViewTextBoxColumn;
    }
}