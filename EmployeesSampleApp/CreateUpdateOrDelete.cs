using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesSampleApp
{
    public partial class CreateUpdateOrDelete : Form
    {
        public CreateUpdateOrDelete(string createOrUpdate = "Create", Employee employee = null)
        {
            InitializeComponent();
            txtEmployeeId.Text = employee == null ? null : employee.EmployeeId.Value.ToString();
            label1.Select();

            if (createOrUpdate == "Update")
            {
                txtFirstName.Text = employee.FirstName;
                txtLastName.Text = employee.LastName;
                txtPhoneNumber.Text = employee.PhoneNumber;
                comboBoxRole.Text = employee.Role;
                chBoxStatus.Checked = employee.Status;
                numUpDownSalary.Value = employee.Salary.GetValueOrDefault();

                Text = "Update";
                btnCreateOrUpdate.Text = "Update";
            }
            else
            {
                Text = "Create";
            }
        }

        private void btnCreateOrUpdate_Click(object sender, EventArgs e)
        {
            int? employeeId = !string.IsNullOrWhiteSpace(txtEmployeeId.Text) ? int.Parse(txtEmployeeId.Text) : (int?)null;

            CreateOrUpdateItem(employeeId);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var affectedRowsCount = Service.DeleteEmployee(int.Parse(txtEmployeeId.Text));

            _ = affectedRowsCount > 0 ? MessageBox.Show("Item deleted successfully") : MessageBox.Show("An error occured");

            Close();
        }

        private void CreateOrUpdateItem(int? employeeId = null)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Enter first name!");
                txtFirstName.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Enter last name!");
                txtLastName.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Enter phone number!");
                txtPhoneNumber.Select();
            }
            else if (comboBoxRole.SelectedIndex <= -1)
            {
                MessageBox.Show("Enter gender!");
                comboBoxRole.Select();
            }
            else if (numUpDownSalary.Value <= 0)
            {
                MessageBox.Show("Enter correct salary!");
                numUpDownSalary.Select();
            }
            else
            {
                var affectedRowsCount = Service.CreateOrUpdateEmployee(new Employee()
                {
                    EmployeeId = employeeId,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Role = comboBoxRole.SelectedItem.ToString(),
                    Status = chBoxStatus.Checked,
                    Salary = Convert.ToDecimal(numUpDownSalary.Value)
                });

                _ = affectedRowsCount > 0 ? MessageBox.Show("Item saved successfully") : MessageBox.Show("An error occured");

                Close();
            }
        }
    }
}
