namespace EmployeesSampleApp
{
    partial class CreateUpdateOrDelete
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.chBoxStatus = new System.Windows.Forms.CheckBox();
            this.btnCreateOrUpdate = new System.Windows.Forms.Button();
            this.numUpDownSalary = new System.Windows.Forms.NumericUpDown();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtEmployeeId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Role";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Phone Number";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(132, 37);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(180, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(132, 77);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(180, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(132, 237);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(180, 20);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Software developer",
            "Scrum master",
            "Product owner",
            "Business analyst"});
            this.comboBoxRole.Location = new System.Drawing.Point(132, 117);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(180, 21);
            this.comboBoxRole.TabIndex = 2;
            // 
            // chBoxStatus
            // 
            this.chBoxStatus.AutoSize = true;
            this.chBoxStatus.Location = new System.Drawing.Point(132, 197);
            this.chBoxStatus.Name = "chBoxStatus";
            this.chBoxStatus.Size = new System.Drawing.Size(56, 17);
            this.chBoxStatus.TabIndex = 3;
            this.chBoxStatus.Text = "Active";
            this.chBoxStatus.UseVisualStyleBackColor = true;
            // 
            // btnCreateOrUpdate
            // 
            this.btnCreateOrUpdate.Location = new System.Drawing.Point(143, 289);
            this.btnCreateOrUpdate.Name = "btnCreateOrUpdate";
            this.btnCreateOrUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCreateOrUpdate.TabIndex = 4;
            this.btnCreateOrUpdate.Text = "Create";
            this.btnCreateOrUpdate.UseVisualStyleBackColor = true;
            this.btnCreateOrUpdate.Click += new System.EventHandler(this.btnCreateOrUpdate_Click);
            // 
            // numUpDownSalary
            // 
            this.numUpDownSalary.Location = new System.Drawing.Point(132, 160);
            this.numUpDownSalary.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numUpDownSalary.Name = "numUpDownSalary";
            this.numUpDownSalary.Size = new System.Drawing.Size(180, 20);
            this.numUpDownSalary.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(143, 332);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.AutoSize = true;
            this.txtEmployeeId.Location = new System.Drawing.Point(35, 9);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(62, 13);
            this.txtEmployeeId.TabIndex = 7;
            this.txtEmployeeId.Text = "EmployeeId";
            this.txtEmployeeId.Visible = false;
            // 
            // CreateUpdateOrDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 375);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.numUpDownSalary);
            this.Controls.Add(this.btnCreateOrUpdate);
            this.Controls.Add(this.chBoxStatus);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateUpdateOrDelete";
            this.Text = "CreateOrUpdate";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.CheckBox chBoxStatus;
        private System.Windows.Forms.Button btnCreateOrUpdate;
        private System.Windows.Forms.NumericUpDown numUpDownSalary;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label txtEmployeeId;
    }
}