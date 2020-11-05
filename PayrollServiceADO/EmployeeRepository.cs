using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace PayrollServiceADO
{
    public class EmployeeRepository
    {
        public static string connectionString = "Server=(localdb)\\MSSQLLocalDB; Initial Catalog =payroll_service; User ID = AkSharma; Password=abhishek123";
       public SqlConnection connection = new SqlConnection(connectionString);
        /// Defining a method to read the exisiting database
        /// with the help of the console application
        public void GetAllEmployees()
        {
            EmployeeModel model = new EmployeeModel();
            try
            {
                using (connection)
                {
                    string query = @"select * from employee_payroll";
                    SqlCommand command = new SqlCommand(query, connection);
                    this.connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            model.EmployeeID = reader.GetInt32(0);
                            model.EmployeeName = reader.GetString(1);
                            model.BasicPay = reader.GetInt32(2);
                            model.StartDate = reader.GetDateTime(3);
                            model.Gender = reader.GetString(4);
                            model.PhoneNumber = reader.GetInt32(5);
                            model.Address = reader.GetString(6);
                            model.Department = reader.GetString(7);
                            model.Deductions = reader.GetDouble(8);
                            model.TaxablePay = reader.GetDouble(9);
                            model.NetPay = reader.GetDouble(10);
                            model.IncomeTax = reader.GetDouble(11);
                            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}", model.EmployeeID, model.EmployeeName, model.Gender, model.Address, model.BasicPay, model.StartDate, model.PhoneNumber, model.Address, model.Department, model.Deductions, model.TaxablePay, model.IncomeTax, model.NetPay);
                            Console.WriteLine("\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No data found");
                    }
                    reader.Close();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }
        /// Method to update the employee table 
        /// as asked in the UC 3
        public bool UpdateTables()
        {
            using (connection)
            {
                try
                {
                    connection.Open();
                    // Enlist a command in the current transaction.
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = "update employee_payroll set Basic_Pay = 40000 where name='Terisa'";
                int numberOfEffectedRows= command.ExecuteNonQuery();
                    if (numberOfEffectedRows != 0)
                    {
                        return true;
                    }
                    else {
                        return false;
                    }
                }
                catch (Exception ex) {
                    throw new Exception(ex.Message);
                }
              
            }
        }
        
    }
}
