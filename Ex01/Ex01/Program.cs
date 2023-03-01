using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("result " + Factorial(number));

        }

        private static int Factorial(int number)
        {
            int res = 1;
            while (number > 1)
            {
                res = number * res;
                number--;
            }
           // throw new NotImplementedException();
            return res;
        }
    }
}
