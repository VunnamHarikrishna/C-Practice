using System;

    class Program
    {
        static void Main(string[] args)
        {
        //ternaray(condition)?True:false          
        int a = 10;
        Console.WriteLine(a==10?false:true);
        bool? check = null;
        if (check==true)
        {
            Console.WriteLine("yes");
        }
        else if (check==false)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine("i don't know");
        }
        int? n= null;
        int chn = n ?? 0;
        Console.WriteLine(chn);
        }
    }

