using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseAndDerived
{
   class Baseone
    {
        public void Show()
        {
            Console.WriteLine("base one method");
        }
    }
    class Derivedone : Baseone
    {
        public void display()
        {

            Console.WriteLine("Derived one");
        }

        //public Derivedone()
        // {
        //     Console.WriteLine("derived ");
        // }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Baseone b1 = new Baseone();
            Derivedone d1 = new Derivedone();
            Baseone b2 = new Derivedone();
            //b2 testing 
            b2.Show();
            // b2.Dispaly();
            //d1 testing
            d1.Show();
            d1.display();
            //b1 testing 
            b1.Show();
            Console.ReadLine();
        }
    }
}
