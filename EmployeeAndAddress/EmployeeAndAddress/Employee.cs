using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAndAddress
{
   public  class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public  EmployeeAddress EmployeeAddress { get; set; }
    }
}
