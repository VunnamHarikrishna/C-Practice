using System;



    class Program
    {
        static void Main(string[] args)
        {
        int i =int.Parse( Console.ReadLine());
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("even number");
                    }
                    else
                    {
                        Console.WriteLine("odd number");
                    }
        ////          switch
                switch (i % 2)
                {
                    case 1:
                        Console.WriteLine("odd number");
                        break;
                    case 0:
                        Console.WriteLine("even number");
                        break;
        }
        // goto
               g: int r=int.Parse(Console.ReadLine());
                if (r == 10)
                {
                    Console.WriteLine("i am in goto");
                    goto g;
                }
        }
    }
