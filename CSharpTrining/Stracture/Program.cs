using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stracture
{
    public struct Student
    {
        public int ID { get; set; }
       public string Name { get; set; }
        
    }

    public class Test
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Student obj = new Student();
            obj.ID = 15;
            obj.Name = "har";
            Student temp = obj;
            temp.ID = 1;
            temp.Name = "get";
            Console.WriteLine(obj.ID+"  "+obj.Name+"\n"+temp.ID+" "+temp.Name);
            Test ob = new Test();
            ob.ID = 12;
            ob.Name = "har";

            Test te = ob;
            te.ID = 14;
            te.Name = "kr";
            Console.WriteLine(ob.ID+" "+ob.Name+" \n" +te.ID+" "+te.Name);


        }
    }
}
