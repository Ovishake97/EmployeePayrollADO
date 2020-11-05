using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayrollServiceADO;
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
        /// TestMethod to check whether the 
        /// update table query is getting executed
        [TestMethod]
        public void GivenQueryUpdatesRows() {
            bool expectedOutput = employee.UpdateTables();
            Assert.IsTrue(expectedOutput);
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
        public void GivenQueryGetsAverageSalary()
        {
            int expectedOutput = employee.GetSalary(@"select avg(basic_pay) from employee_payroll where Gender = 'M'");
            int actualOutput = 470449;
            expectedOutput.Equals(actualOutput);
        }
        /// Test case for checking total salary of female employees
        [TestMethod]
        public void GivenQueryGetsTotalSalary()
        {
            int expectedOutput = employee.GetSalary(@"select sum(basic_pay) from employee_payroll where Gender='F'");
            int actualOutput = 73348;
            expectedOutput.Equals(actualOutput);
        }
        /// Test case for checking maximum salary from the male employees
        [TestMethod]
        public void GivenQueryGetsMaximumSalary()
        {
            int expectedOutput = employee.GetSalary(@"select max(basic_pay) from employee_payroll where Gender='M'");
            int actualOutput = 494949;
            expectedOutput.Equals(actualOutput);

        }
        /// Testcase for checking operation performed on the normalised tables
        /// Operations are done using subqueries and the normalised tables are connected
        /// through a set of primary keys and foregin keys
        [TestMethod]
        public void GivenSubQueryUpdatesDepartmentTable() {
            DepartmentRepo department = new DepartmentRepo();
            bool expectedOutput = department.UpdateDepartmentTable();
            Assert.IsTrue(expectedOutput);
        }
        [TestMethod]
        public void GivenSubQueryGivesMaximumSalary()
        {
            int expectedOutput = employee.GetSalary(@"select Max(basic_pay) from salary where dept_id in(select dept_id from department where id in(select id from employee_details where gender='M'))");
            int actualOutput = 575758;
            actualOutput.Equals(expectedOutput);
        }
        [TestMethod]
        public void GivenSubQueryGivesTotalSalary() {
            int expectedOutput = employee.GetSalary(@"select Sum(basic_pay) from salary where dept_id in(select dept_id from department where id in(select id from employee_details where gender='F'))");
            int actualOutput = 499494;
            actualOutput.Equals(expectedOutput);
        }
    }
}
