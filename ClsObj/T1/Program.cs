using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 10, 20, 20, 10, };
            int[] count = new int[arr.Length];
            Console.WriteLine(arr);
            for(int i = 0; i < arr.Length; i++)
            {
               //int coun = 0;
                for(int j = i+1; j < arr.Length; j++)
                {
                    if ((arr[i] == arr[j])&&(arr[i]!=0))
                    {
                        count[i]++;
                        arr[j] = 0;
                    }
                }
            }

            for(int i = 0; i < arr.Length; i++)
            {
                if (count[i] > 0)
                {
                    Console.Write(arr[i]+"   ");
                }
            }
            Console.ReadLine();

        }
    }
}
