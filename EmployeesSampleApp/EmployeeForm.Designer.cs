namespace EmployeesSampleApp
{
    partial class EmployeeForm
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
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.DataGridViewCellEventArgs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chboxStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtEntriesCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPageNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemsPerPage = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSearchRole = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numSearchSalaryFrom = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numSearchSalaryPriorTo = new System.Windows.Forms.NumericUpDown();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSearchSalaryFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSearchSalaryPriorTo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AllowUserToAddRows = false;
            this.dataGridViewEmployees.AllowUserToDeleteRows = false;
            this.dataGridViewEmployees.AllowUserToOrderColumns = true;
            this.dataGridViewEmployees.AllowUserToResizeRows = false;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewCellEventArgs,
            this.txtFirstName,
            this.txtLastName,
            this.Role,
            this.txtSalary,
            this.chboxStatus});
            this.dataGridViewEmployees.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(12, 133);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.ReadOnly = true;
            this.dataGridViewEmployees.ShowEditingIcon = false;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(1026, 314);
            this.dataGridViewEmployees.TabIndex = 0;
            this.dataGridViewEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployees_CellContentClick);
            this.dataGridViewEmployees.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVIewEmployees_CellDoubleClick);
            this.dataGridViewEmployees.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewEmployees_DataBindingComplete);
            // 
            // DataGridViewCellEventArgs
            // 
            this.DataGridViewCellEventArgs.DataPropertyName = "Id";
            this.DataGridViewCellEventArgs.HeaderText = "EmployeeId";
            this.DataGridViewCellEventArgs.Name = "DataGridViewCellEventArgs";
            this.DataGridViewCellEventArgs.ReadOnly = true;
            this.DataGridViewCellEventArgs.Visible = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataPropertyName = "FirstName";
            this.txtFirstName.HeaderText = "First Name";
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            // 
            // txtLastName
            // 
            this.txtLastName.DataPropertyName = "LastName";
            this.txtLastName.HeaderText = "Last Name";
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // txtSalary
            // 
            this.txtSalary.DataPropertyName = "Salary";
            this.txtSalary.HeaderText = "Salary";
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            // 
            // chboxStatus
            // 
            this.chboxStatus.DataPropertyName = "Status";
            this.chboxStatus.HeaderText = "Status";
            this.chboxStatus.Name = "chboxStatus";
            this.chboxStatus.ReadOnly = true;
            this.chboxStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chboxStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(38, 31);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(139, 31);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtEntriesCount
            // 
            this.txtEntriesCount.AutoSize = true;
            this.txtEntriesCount.Location = new System.Drawing.Point(255, 36);
            this.txtEntriesCount.Name = "txtEntriesCount";
            this.txtEntriesCount.Size = new System.Drawing.Size(98, 13);
            this.txtEntriesCount.TabIndex = 3;
            this.txtEntriesCount.Text = "Total entries count:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current page: ";
            // 
            // txtPageNumber
            // 
            this.txtPageNumber.Location = new System.Drawing.Point(452, 33);
            this.txtPageNumber.Name = "txtPageNumber";
            this.txtPageNumber.Size = new System.Drawing.Size(44, 20);
            this.txtPageNumber.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Items per page: ";
            // 
            // txtItemsPerPage
            // 
            this.txtItemsPerPage.Location = new System.Drawing.Point(619, 33);
            this.txtItemsPerPage.Name = "txtItemsPerPage";
            this.txtItemsPerPage.Size = new System.Drawing.Size(44, 20);
            this.txtItemsPerPage.TabIndex = 5;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(673, 31);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(38, 24);
            this.btnGo.TabIndex = 7;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnPaging_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "First Name:";
            // 
            // txtSearchFirstName
            // 
            this.txtSearchFirstName.Location = new System.Drawing.Point(92, 87);
            this.txtSearchFirstName.Name = "txtSearchFirstName";
            this.txtSearchFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtSearchFirstName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Last Name:";
            // 
            // txtSearchLastName
            // 
            this.txtSearchLastName.Location = new System.Drawing.Point(283, 87);
            this.txtSearchLastName.Name = "txtSearchLastName";
            this.txtSearchLastName.Size = new System.Drawing.Size(100, 20);
            this.txtSearchLastName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Role:";
            // 
            // comboBoxSearchRole
            // 
            this.comboBoxSearchRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchRole.FormattingEnabled = true;
            this.comboBoxSearchRole.Items.AddRange(new object[] {
            "Software developer",
            "Scrum master",
            "Product owner",
            "Business analyst"});
            this.comboBoxSearchRole.Location = new System.Drawing.Point(454, 87);
            this.comboBoxSearchRole.Name = "comboBoxSearchRole";
            this.comboBoxSearchRole.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSearchRole.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(604, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Salary from:";
            // 
            // numSearchSalaryFrom
            // 
            this.numSearchSalaryFrom.Location = new System.Drawing.Point(670, 87);
            this.numSearchSalaryFrom.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numSearchSalaryFrom.Name = "numSearchSalaryFrom";
            this.numSearchSalaryFrom.Size = new System.Drawing.Size(47, 20);
            this.numSearchSalaryFrom.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(739, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Salary to:";
            // 
            // numSearchSalaryPriorTo
            // 
            this.numSearchSalaryPriorTo.Location = new System.Drawing.Point(793, 87);
            this.numSearchSalaryPriorTo.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numSearchSalaryPriorTo.Name = "numSearchSalaryPriorTo";
            this.numSearchSalaryPriorTo.Size = new System.Drawing.Size(47, 20);
            this.numSearchSalaryPriorTo.TabIndex = 14;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(863, 85);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 16;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(944, 85);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 472);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.numSearchSalaryPriorTo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numSearchSalaryFrom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxSearchRole);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearchLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearchFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtItemsPerPage);
            this.Controls.Add(this.txtPageNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEntriesCount);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSearchSalaryFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSearchSalaryPriorTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewCellEventArgs;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSalary;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chboxStatus;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label txtEntriesCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPageNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItemsPerPage;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearchFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearchLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSearchRole;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numSearchSalaryFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numSearchSalaryPriorTo;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnClear;
    }
}