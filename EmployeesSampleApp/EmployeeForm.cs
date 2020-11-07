using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesSampleApp
{
    public partial class EmployeeForm : Form
    {
        private bool AddedUpdateAndDeleteColumns = false;
        public EmployeeForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void dataGridVIewEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int employeeId = (int)dataGridViewEmployees.Rows[e.RowIndex].Cells[0].Value;

            OpenUpdateForm(e, employeeId);
        }
        private void dataGridViewEmployees_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewEmployees.Rows)
            {
                row.Cells[row.Cells.Count - 1].Value = "Delete";
                row.Cells[row.Cells.Count - 2].Value = "Update";
            }
        }

        private void dataGridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                int employeeId = (int)dataGridViewEmployees.Rows[e.RowIndex].Cells[0].Value;

                if (e.ColumnIndex == 7)
                {
                    DeleteItem(employeeId);
                }
                else if (e.ColumnIndex == 6)
                {
                    OpenUpdateForm(e, employeeId);
                    LoadData();
                }
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            new CreateUpdateOrDelete().ShowDialog();
            LoadData();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnPaging_Click(object sender, EventArgs e)
        {
            Paging();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearchFirstName.Text = null;
            txtSearchLastName.Text = null;
            comboBoxSearchRole.SelectedItem = null;
            numSearchSalaryFrom.Value = 0;
            numSearchSalaryPriorTo.Value = 0;

            LoadData();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string firstName = txtSearchFirstName.Text;
            string lastName = txtSearchLastName.Text;
            string role = comboBoxSearchRole.SelectedItem == null ? null : comboBoxSearchRole.SelectedItem.ToString();
            decimal? salaryFrom = numSearchSalaryFrom.Value == 0 ? (decimal?)null : numSearchSalaryFrom.Value;
            decimal? salaryPriorTo = numSearchSalaryPriorTo.Value == 0 ? (decimal?)null : numSearchSalaryPriorTo.Value;

            SearchEmployees(firstName, lastName, role, salaryFrom, salaryPriorTo);
        }

        private void LoadData()
        {
            AddUpdateAndDeleteColumns();

            var employees = LoadEmployees();
            
            if(employees != null)
            {
                txtItemsPerPage.Text = employees.Rows.Count.ToString();
                txtPageNumber.Text = 1.ToString();
                txtEntriesCount.Text = "Total entries count: " + employees.Rows.Count;
            }
        }

        private DataTable LoadEmployees(int? offset = null, int? take = null)
        {
            var employees = Service.GetEmployees(offset, take);
            dataGridViewEmployees.AutoGenerateColumns = false;
            dataGridViewEmployees.DataSource = employees;

            return employees;
        }

        private void SearchEmployees(string firstName, string lastName, string role, decimal? salaryFrom, decimal? salaryPriorTo)
        {
            var employees = Service.Search(firstName, lastName, role, salaryFrom, salaryPriorTo);

            if(employees != null)
            {
                dataGridViewEmployees.AutoGenerateColumns = false;
                dataGridViewEmployees.DataSource = employees;

                txtItemsPerPage.Text = employees.Rows.Count.ToString();
                txtPageNumber.Text = 1.ToString();
                txtEntriesCount.Text = "Total entries count: " + employees.Rows.Count;
            }
        }

        private void AddUpdateAndDeleteColumns()
        {
            if (!AddedUpdateAndDeleteColumns)
            {
                dataGridViewEmployees.Columns.Add(new DataGridViewLinkColumn());
                dataGridViewEmployees.Columns.Add(new DataGridViewLinkColumn());
                AddedUpdateAndDeleteColumns = true;
            }
        }

        private void OpenUpdateForm(EventArgs e, int employeeId)
        {
            var employee = Service.GetEmployeeById(employeeId);

            new CreateUpdateOrDelete("Update", new Employee()
            {
                EmployeeId = employeeId,
                FirstName = employee["FirstName"].ToString(),
                LastName = employee["LastName"].ToString(),
                PhoneNumber = employee["PhoneNumber"].ToString(),
                Role = employee["Role"].ToString(),
                Status = (bool)employee["Status"],
                Salary = Convert.ToDecimal(employee["Salary"])
            }).ShowDialog();
        }
        private void Paging()
        {
            var offsetIsValid = int.TryParse(txtPageNumber.Text, out int offset);
            var takeIsValid = int.TryParse(txtItemsPerPage.Text, out int take);
            if (!offsetIsValid)
            {
                MessageBox.Show("Page number is not valid");
                txtPageNumber.Select();
            }
            else if (!takeIsValid)
            {
                MessageBox.Show("Items number is not valid");
                txtPageNumber.Select();
            }
            else
            {
                LoadEmployees(offset, take);
            }
        }
        private void DeleteItem(int employeeId)
        {
            var affectedRowsCount = Service.DeleteEmployee(employeeId);

            _ = affectedRowsCount > 0 ? MessageBox.Show("Item deleted successfully") : MessageBox.Show("An error occured");

            LoadData();
        }
    }
}
