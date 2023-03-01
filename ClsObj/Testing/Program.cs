using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Testing
{
     
    abstract class A
    {
       public abstract void M2();
       public void M1() { Console.WriteLine("M1"); }
    }
    abstract class B : A
    {

    }
    abstract class C : A
    {

    }
    class D : Student
    {
        public void Dis()
        {
            Console.WriteLine();
        }
    }
    
    class Program:B
    {
      public override void M2()
        {
            Console.WriteLine("M2");
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.M1();
            obj.M2();

            String[] str = new string[2] { "hari","mani"};
            Console.WriteLine(str[);
            Console.ReadLine();
        }
    }
}
