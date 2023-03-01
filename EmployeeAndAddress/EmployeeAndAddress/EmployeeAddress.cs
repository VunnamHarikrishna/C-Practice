using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAndAddress
{
   public class EmployeeAddress
    {
        public int DoorNo { get; set; }
        public  string StreetName1 { get; set; }
        public  string StreetName2 { get; set; }
        public string City { get; set; }

        public Employee Employee { get; set; }
    }
}
