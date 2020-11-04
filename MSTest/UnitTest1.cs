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
    }
}
