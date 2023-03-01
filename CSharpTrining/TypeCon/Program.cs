using System;



    class Program
    {
        static void Main(string[] args)
        {
        int a = 10;
        float b = a;//implecit 
        Console.WriteLine(b);
        b = 143843871541.3f;
        a =(int) b;
        Console.WriteLine(a);
       // a = Convert.ToInt32(b);
        Console.WriteLine(a);
        string str = "100";
        int tem = int.Parse(str);
        Console.WriteLine(tem);
        }
    }

