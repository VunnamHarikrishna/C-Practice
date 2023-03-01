using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsArrayList
{
    class Student
    {
        public int id;
        public string name;
    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> studetsdata = new List<Student>();

            Console.WriteLine("enter no of students ");
            int n = int.Parse(Console.ReadLine());
            Student obj = new Student();
            try
            {
                for (int i = 0; i < n; i++)
                {
                    try
                    {
                                             
                        Console.WriteLine("enter stdent id");
                        obj.id = int.Parse(Console.ReadLine());
                      
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("enter name");
                        obj.name = Console.ReadLine();
                        studetsdata.Add(obj);
                        throw new Exception("main ",ex);
                    }
                }
            }
            catch(Exception ex)
            {

                Console.WriteLine(ex.InnerException.Message);
                Console.WriteLine(ex.Message);
            }
           
            Console.WriteLine("enter no of students ");
           n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
              //  Student obj = new Student();
                Console.WriteLine("enter stdent id");
                obj.id = int.Parse(Console.ReadLine());
                Console.WriteLine("enter name");
                obj.name = Console.ReadLine();
                studetsdata.Add(obj);
            }

            foreach (Student temp in studetsdata)
            {
                Console.WriteLine(temp.id+" "+temp.name);
            }
            Console.ReadLine();
        }
    }
}
