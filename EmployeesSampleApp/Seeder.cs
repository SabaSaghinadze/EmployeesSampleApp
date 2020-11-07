using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeesSampleApp
{
    public static class Seeder
    {
        public static void Seed()
        {
            var query = @"
                insert into Employees(FirstName, LastName, Role, Salary, PhoneNumber, Status)
                SELECT 'Bidzina', 'Tabagari', 'Software developer', 10000, '555111222', 1
                WHERE NOT EXISTS (Select * FROM Employees WHERE FirstName='Bidzina')

                INSERT INTO Employees(FirstName, LastName, Role, Salary, PhoneNumber, Status)
                SELECT 'Leqso', 'Nijaradze', 'Software developer', 5000, '555222333', 1
                WHERE NOT EXISTS (Select * FROM Employees WHERE FirstName='Leqso')

                INSERT INTO Employees(FirstName, LastName, Role, Salary, PhoneNumber, Status)
                SELECT 'Givi', 'Intskirveli', 'Product owner', 20000, '555333444', 1
                WHERE NOT EXISTS (Select * FROM Employees WHERE FirstName='Givi')

                INSERT INTO Employees(FirstName, LastName, Role, Salary, PhoneNumber, Status)
                SELECT 'Ucha', 'Zeragia', 'Scrum master', 100000, '555444555', 0
                WHERE NOT EXISTS (Select * FROM Employees WHERE FirstName='Ucha')

                INSERT INTO Employees(FirstName, LastName, Role, Salary, PhoneNumber, Status)
                SELECT 'Amiran', 'Brodzeli', 'Software developer', 50000, '555555555', 0
                WHERE NOT EXISTS (Select * FROM Employees WHERE FirstName='Amiran')

                INSERT INTO Employees(FirstName, LastName, Role, Salary, PhoneNumber, Status)
                SELECT 'Geno', 'Shavdia', 'Product owner', 20000, '555777777', 1
                WHERE NOT EXISTS (Select * FROM Employees WHERE FirstName='Geno')
            ";

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Service.ConnectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("An error occured");
            }
        }
    }
}
