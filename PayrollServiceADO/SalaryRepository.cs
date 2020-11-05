using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace PayrollServiceADO
{
  public  class SalaryRepository
    {
        public static string connectionString = "Server=(localdb)\\MSSQLLocalDB; Initial Catalog =payroll_service; User ID = AkSharma; Password=abhishek123";
        public SqlConnection connection = new SqlConnection(connectionString);
        /// Method defined to add values to the normalised salary table 
        /// by passing SalaryModel object as parameter
        public void AddSalary(SalaryModel salary) {
            try
            {
                using (this.connection) {
                    SqlCommand command = new SqlCommand("dbo.AddSalary", this.connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@deptId", salary.deptId);
                    command.Parameters.AddWithValue("@basic_pay", salary.basicPay);
                    command.Parameters.AddWithValue("@deductions", salary.deduction);
                    command.Parameters.AddWithValue("@taxable_pay", salary.taxablePay);
                    command.Parameters.AddWithValue("@income_tax", salary.incomeTax);
                    command.Parameters.AddWithValue("@net_pay", salary.netPay);
                    Console.WriteLine("Added sucessfully");
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
