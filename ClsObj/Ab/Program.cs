using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab
{
   
   public abstract class Test1
    {
        public abstract  void Display();
       public void p()
        {
            Console.WriteLine("hi");
        }
    }
  
 
    class Program : Test1
    {
        public override void Display()
        {
            Console.WriteLine("hello");

        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Display();
             obj.p();
            Console.ReadLine();
        }
        
       
    }
}
