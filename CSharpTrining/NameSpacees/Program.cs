using System;
using PAPA =ProjectA.TeamA;

    class Program
    {
        static void Main(string[] args)
        {
        // ProjectA.TeamA.clsA.Print();
        PAPA.clsA.Print();
        ProjectA.TeamB.clsA.Print();
        
        Console.WriteLine();
        }
    }
/// <summary>
///                 this is project A Team a
/// </summary>
namespace ProjectA
{
    namespace TeamA
    {
        class clsA
        {
            public static void Print()
            {
                Console.WriteLine("this is Team A");
            }
        }
    }
}
namespace ProjectA
{
    namespace TeamB
    {
        class clsA
        {
            public static void Print()
            {
                Console.WriteLine("this is Team B");
            }
        }
    }
}