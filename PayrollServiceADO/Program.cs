using System;
using System.Collections.Generic;

namespace PayrollServiceADO
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository repository = new EmployeeRepository();
            Console.WriteLine(repository.GetSalary(@"select max(basic_pay) from employee_payroll where Gender='M'"));
            
        }
    }
}
