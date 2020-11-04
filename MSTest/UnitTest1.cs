using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        PayrollServiceADO.EmployeeRepository employee = null;
        List<string> expected;
        List<string> actual;
        [TestInitialize]
        public void SetUp() {
            employee = new PayrollServiceADO.EmployeeRepository();
            expected = new List<string>();
            actual = new List<string>();
        }
        /// Test method to validate the method defined for UC5
        [TestMethod]
        public void GivesEmployeeJoinsAfterADate()
        {
            expected = employee.GetEmployeesJoiningAfterADate();
            actual.Add("Mahesh");
            actual.Add("Pooja");
            actual.Add("Terisa");
            expected.Equals(actual);
        }
        /// Test case for checking average salary of male employees
        [TestMethod]
        public void GivenQueryGetsAverageSalary() {
            int expectedOutput = employee.GetSalary(@"select avg(basic_pay) from employee_payroll where Gender = 'M'");
            int actualOutput = 470449;
            expectedOutput.Equals(actualOutput);
        }
        /// Test case for checking total salary of female employees
        [TestMethod]
        public void GivenQueryGetsTotalSalary() {
            int expectedOutput = employee.GetSalary(@"select sum(basic_pay) from employee_payroll where Gender='F'");
            int actualOutput = 73348;
            expectedOutput.Equals(actualOutput);
        }
        /// Test case for checking maximum salary from the male employees
        [TestMethod]
        public void GivenQueryGetsMaximumSalary() {
            int expectedOutput = employee.GetSalary(@"select max(basic_pay) from employee_payroll where Gender='M'");
            int actualOutput = 494949;
            expectedOutput.Equals(actualOutput);

        }
    }
}
