using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandle2
{
    class Program
    {
        static void Main(string[] args)
        {
           // Fun1();
            Fun2();


        }
        static void Fun1()
        {
            StreamReader Read = null;
            try
            {
                Read = new StreamReader(@"D:\C#\Practice\CSharpTrining\ExceptionHandling\file_created by hari\Doc1.txt");
                Console.WriteLine(Read.ReadToEnd());
            }
            catch
            {
                Console.WriteLine("error occerd");
            }
            finally
            {
                if (Read != null)
                {
                    Read.Close();
                }
                Console.WriteLine("Finally completed");
            }
        }
        static void Fun2()
        {
            try
            {
                try
                {
                    Console.WriteLine("enter a num1: ");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter a num2: ");
                    int num2 = int.Parse(Console.ReadLine());
                    int res = num1 / num2;
                    Console.WriteLine("result : " + res);
                }
                catch (ArithmeticException ex)
                {
                    string fileloc = @"D:\C#\Practice\CSharpTrining\ExceptionHandling\file_created by hari\Doc2.txt";
                    
                    if (File.Exists(fileloc))
                    {
                        StreamWriter sw = new StreamWriter(fileloc);
                        sw.WriteLine(ex.Message);
                    }
                    else
                    {
                        throw new FileNotFoundException("file not found", ex);
                    }


                }


            }
            catch (Exception Excp)
            {
                Console.WriteLine("current exception" + Excp.GetType().Name);
                Console.WriteLine("inner Exception" + Excp.InnerException.GetType().Name);
            }
            finally
            {
                Console.WriteLine("Done");
            }

        }
    }
}

      

