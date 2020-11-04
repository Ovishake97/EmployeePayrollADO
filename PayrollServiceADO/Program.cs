using System;

namespace PayrollServiceADO
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository repository = new EmployeeRepository();
             repository.GetAllEmployees();
        }
    }
}
