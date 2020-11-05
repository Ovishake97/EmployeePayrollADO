using System;
using System.Collections.Generic;

namespace PayrollServiceADO
{
    class Program
    {
        static void Main(string[] args)
        {
            SalaryModel model = new SalaryModel();
            model.deptId = 105;
            model.basicPay = 500234;
            model.deduction = 890;
            model.taxablePay = 123;
            model.incomeTax = 201;
            model.netPay = 48023;
            SalaryRepository repository = new SalaryRepository();
            repository.AddSalary(model);
        }
    }
}
