using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsObj
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            str = Upper(str);
            Console.WriteLine(str);
            Console.ReadLine();
            
        }
        static string Upper(String str)
        {
            string res = "";
            for(int i = 0; i < str.Length; i++)
            {
                int temp = str[i] ;
                if ((temp > 96 && temp < 123))
                {
                    temp = temp - 32;
                    char temp2 =(char) temp;
                    res += temp2;          
                }
            }
            return res;
        }
    }
}
