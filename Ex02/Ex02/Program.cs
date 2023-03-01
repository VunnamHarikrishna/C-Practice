using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            DispayResult(number);
        }

        private static void DispayResult(int number)
        {
            for(int i = 0; i < 13; i++)
            {
                Console.WriteLine(number + " * "+i+" = "+(number*i));
            }
        }

    }
}
