using System.Data;
using System.Data.SqlClient;

namespace EmployeesSampleApp
{
    public static class Service
    {
        public const string ConnectionString = "Server=.\\SQLEXPRESS;Trusted_Connection=True;Database=EmployeesDb;MultipleActiveResultSets=true";

        public static DataTable GetEmployees(int? pageNumber = null, int? itemsPerPage = null)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    sqlConnection.Open();
                    DataTable dtData = new DataTable();
                    SqlCommand sqlCommand = new SqlCommand("EmployeeProcedure", sqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ActionType", "GetData");

                    if (pageNumber != null && itemsPerPage != null)
                    {
                        sqlCommand.Parameters.AddWithValue("@Offset", (pageNumber - 1) * itemsPerPage);
                        sqlCommand.Parameters.AddWithValue("@Take", itemsPerPage);
                    }

                    SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCommand);
                    sqlSda.Fill(dtData);

                    sqlConnection.Close();
                    sqlCommand.Dispose();

                    return dtData;
                }
            }
            catch
            {
                return null;
            }
        }

        public static DataRow GetEmployeeById(int employeeId)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Service.ConnectionString))
                {
                    sqlConnection.Open();
                    DataTable dtData = new DataTable();
                    SqlCommand sqlCommand = new SqlCommand("EmployeeProcedure", sqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ActionType", "GetById");
                    sqlCommand.Parameters.AddWithValue("@Id", employeeId);
                    SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCommand);
                    sqlSda.Fill(dtData);

                    sqlConnection.Close();
                    sqlCommand.Dispose();

                    return dtData.Rows[0];
                }
            }
            catch
            {
                return null;
            }
        }

        public static DataTable Search(string firstName = null, string lastName = null, string role = null, decimal? salaryFrom = null, decimal? salaryTo = null)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Service.ConnectionString))
                {
                    sqlConnection.Open();
                    DataTable dtData = new DataTable();
                    SqlCommand sqlCommand = new SqlCommand("EmployeeProcedure", sqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ActionType", "Search");
                    if (!string.IsNullOrWhiteSpace(firstName)) sqlCommand.Parameters.AddWithValue("@FirstName", firstName);
                    if (!string.IsNullOrWhiteSpace(lastName)) sqlCommand.Parameters.AddWithValue("@LastName", lastName);
                    if (!string.IsNullOrWhiteSpace(role)) sqlCommand.Parameters.AddWithValue("@Role", role);
                    if (salaryFrom != null) sqlCommand.Parameters.AddWithValue("@SalaryFrom", salaryFrom.ToString());
                    if (salaryTo != null) sqlCommand.Parameters.AddWithValue("@SalaryPriorTo", salaryTo.ToString());
                    SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCommand);
                    sqlSda.Fill(dtData);

                    sqlConnection.Close();
                    sqlCommand.Dispose();

                    return dtData;
                }
            }
            catch
            {
                return null;
            }
        }

        public static int DeleteEmployee(int employeeId)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Service.ConnectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("EmployeeProcedure", sqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ActionType", "DeleteData");
                    sqlCommand.Parameters.AddWithValue("@Id", employeeId);
                    int affectedRowsCount = sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    sqlCommand.Dispose();

                    return affectedRowsCount;
                }
            }
            catch
            {
                return 0;
            }

        }

        public static int CreateOrUpdateEmployee(Employee employee)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    sqlConnection.Open();
                    DataTable dtData = new DataTable();
                    SqlCommand sqlCommand = new SqlCommand("EmployeeProcedure", sqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ActionType", "SaveData");
                    if (employee.EmployeeId != null) sqlCommand.Parameters.AddWithValue("@Id", employee.EmployeeId.Value);
                    sqlCommand.Parameters.AddWithValue("@FirstName", employee.FirstName);
                    sqlCommand.Parameters.AddWithValue("@LastName", employee.LastName);
                    sqlCommand.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNumber);
                    sqlCommand.Parameters.AddWithValue("@Role", employee.Role);
                    sqlCommand.Parameters.AddWithValue("@Salary", employee.Salary);
                    sqlCommand.Parameters.AddWithValue("@Status", employee.Status);
                    int affectedRowsCount = sqlCommand.ExecuteNonQuery();

                    sqlConnection.Close();
                    sqlCommand.Dispose();

                    return affectedRowsCount;
                }
            }
            catch
            {
                return 0;
            }

        }
    }
}
