using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace PayrollServiceADO
{
    public class DepartmentRepo
    {
        public static string connectionString = "Server=(localdb)\\MSSQLLocalDB; Initial Catalog =payroll_service; User ID = AkSharma; Password=abhishek123";
        public SqlConnection connection = new SqlConnection(connectionString);
        /// A method to add values to the newly created normalised department table
        public void AddDepartment(DepartmentModel dept)
        {
            try
            {
                using (this.connection)
                {
                    SqlCommand command = new SqlCommand("dbo.AddDepartments", this.connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@dept_id", dept.deptId);
                    command.Parameters.AddWithValue("@deptname", dept.deptName);
                    command.Parameters.AddWithValue("@id", dept.employeeId);
                    command.Parameters.AddWithValue("@address", dept.address);
                    Console.WriteLine("Added sucessfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// Method to update department details
        /// which returns true if the method runs
        public bool UpdateDepartmentTable()
        {
            using (connection)
            {
                try
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = "update department set address='Chennai' where id in(select id from employee_details where name='Naveen')";
                    int numberOfEffectedRows = command.ExecuteNonQuery();
                    if (numberOfEffectedRows != 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}
