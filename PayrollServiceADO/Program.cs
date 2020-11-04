using System;
using System.Collections.Generic;

namespace PayrollServiceADO
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository repository = new EmployeeRepository();
            List<string> models = new List<string>();
                models=  repository.GetEmployeesJoiningAfterADate();
            foreach(var element in models)
            {
                Console.WriteLine(element);
            }
            
        }
    }
}
