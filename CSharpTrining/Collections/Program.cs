using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(1);
            foreach(int t in list)
            {

                Console.WriteLine(t);
            }
            Console.WriteLine("---------------------------------------");
            HashSet<int> hset = new HashSet<int>();
            hset.Add(1);
            hset.Add(1);
            foreach (int t in hset)
            {

                Console.WriteLine(t);
            }
            Console.ReadLine();
        }
    }
}
