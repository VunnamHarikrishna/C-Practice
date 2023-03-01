using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayObject
{
    class Student
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter no of students: ");
            int no = int.Parse(Console.ReadLine());
            Student[] studata = new Student[no];
            for (int i=0;i<no;i++)
            {
                Student obj = new Student();
                Console.WriteLine("enter id");
                obj.id = int.Parse(Console.ReadLine());
                Console.WriteLine("enter name");
                obj.name = Console.ReadLine();
                studata[i] = obj;
            }

            for(int i = 0; i < no; i++)
            {
                Console.WriteLine($"student id :{studata[i].id} student name : {studata[i].name}");
            }
            Console.ReadLine();
        }
    }
}
