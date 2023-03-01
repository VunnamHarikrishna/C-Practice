using System;


namespace ReadLinefun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your first  name: ");
            string FirstName = Console.ReadLine();
            Console.WriteLine("enter your first  name: ");
            string LastName = Console.ReadLine();
            Console.WriteLine("Hello "+ FirstName+","+ LastName);
            Console.WriteLine("Hello {0},{1}", FirstName, LastName);
            Console.WriteLine($"Hello {FirstName},{LastName}");
        }
    }
}
