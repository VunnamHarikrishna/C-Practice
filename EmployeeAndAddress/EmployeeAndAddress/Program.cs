using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAndAddress
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            EmployeeAddress employeeAddress = new EmployeeAddress();

            employee= FillEmployeeData(employee);

            employeeAddress= FillEmployeeAddress(employee);
            //adding emloyeeAddress to eployee
            employee.EmployeeAddress = employeeAddress;

            //adding employyee to employeeAddress
            employeeAddress.Employee = employee;

            displayEmployeedata(employee);
            displayEmployeeAddressdata(employeeAddress);
            Console.ReadLine();
        }

        private static EmployeeAddress FillEmployeeAddress(Employee employee)
        {
            EmployeeAddress employeeAddress = new EmployeeAddress();

            Console.WriteLine("enter door no");
            employeeAddress.DoorNo = int.Parse(Console.ReadLine());
            Console.WriteLine("enter streetnumber1");
            employeeAddress.StreetName1 =Console.ReadLine();
            Console.WriteLine("enter streetnumber2");
            employeeAddress.StreetName2 = Console.ReadLine();
            Console.WriteLine("enter city name: ");
            employeeAddress.City = Console.ReadLine();

            employeeAddress.Employee = employee;

            return employeeAddress;
        }

        private static Employee FillEmployeeData(Employee employee)
        {
            Console.WriteLine("enter id");
            int empid = int.Parse(Console.ReadLine());
            Console.WriteLine("enter Name: ");
            string empname = Console.ReadLine();
            employee.EmployeeID = empid;
            employee.EmployeeName = empname;

            return employee;
        }

        private static void displayEmployeeAddressdata(EmployeeAddress employeeAddress)
        {
            Console.WriteLine($"DoorNo  {employeeAddress.DoorNo}");
            Console.WriteLine($"street1 : {employeeAddress.StreetName1} {employeeAddress.StreetName2}");
            Console.WriteLine($"city {employeeAddress.City}");
            Console.WriteLine($"employeeID {employeeAddress.Employee.EmployeeID} employeeName {employeeAddress.Employee.EmployeeName}");

        }

        private static void displayEmployeedata(Employee employee)
        {
            Console.WriteLine($"employeeID {employee.EmployeeID} employeeName {employee.EmployeeName}");
            Console.WriteLine($"DoorNo  {employee.EmployeeAddress.DoorNo}");
            Console.WriteLine($"street1 : {employee.EmployeeAddress.StreetName1} {employee.EmployeeAddress.StreetName2}");
            Console.WriteLine($"city {employee.EmployeeAddress.City}");
        
        }
    }
}
