using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollServiceADO
{
   public class SalaryModel
    {
        public int deptId { get; set; }
        public int basicPay { get; set; }
        public int deduction { get; set; }
        public int taxablePay { get; set; }
        public int incomeTax { get; set; }
        public int netPay { get; set; }
    }
}
