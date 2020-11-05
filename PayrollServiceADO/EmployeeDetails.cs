using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollServiceADO
{
   public class EmployeeDetails
    {
        public int employeeID { get; set; }
        public string employeeName { get; set; }
        public string gender { get; set; }
        public DateTime startDate { get; set; }
    }
}
