using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            FileIOException();
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Fun2();
            Console.ReadLine();


        }
        static void Fun2()
        {
          
            try
            {
               Console.WriteLine("enter number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number");
            int number2 = int.Parse(Console.ReadLine());
            int res = 0;
                res = number1 / number2;
            }
            catch(Exception ex) {
                string filepath = @"D:\C#\Practice\CSharpTrining\ExceptionHandling\file_created by hari\Doc.txt";
                StreamWriter sw = new StreamWriter(filepath);
                sw.Write(ex.GetType().Name);
                sw.Close();
                Console.WriteLine("error in innerexception");
            }
        }
        static void FileIOException()
        {
            StreamReader Read = null;
            try
            {
                 Read = new StreamReader(@"D:\C#\Practice\CSharpTrining\ExceptionHandling\file_created by hari\Doc1.txt");
             Console.WriteLine(Read.ReadToEnd());
                
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("file not found");
            }
            catch (Exception ex)
                {
                    Console.WriteLine(" error occur");
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
                finally
                {
                    if (Read != null)
                    {
                        Read.Close();
                    }
                    Console.WriteLine("done ");

                }
        }
    }
}
