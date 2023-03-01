using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ec
{
    class Student
    {
        int id;
        public int ID
        {
            set
            {
                this.id = value;
            }
            get
            {
                return this.id;
            }
        }
    }
   
  
    
    class Program : Student
    {
        
        static void Main(string[] args)
        {
            Program obj = new Program();
            
            Console.WriteLine("enter name: ");
             int ID =int.Parse( Console.ReadLine());
            obj.ID = ID;
            Console.WriteLine(obj.ID);
            Console.ReadLine();
        }
    }
}
