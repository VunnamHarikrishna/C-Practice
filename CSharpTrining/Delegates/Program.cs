using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate  void DeligateFun(string str);
    class Program
    {
        static void Main(string[] args)
        {
            DeligateFun del = new DeligateFun(Hello);
            del("hello function");

            HashSet<string> s = new HashSet<string>();
        }
        public static void Hello(string str)
        {
            Console.WriteLine(str);
        }
    }
}
