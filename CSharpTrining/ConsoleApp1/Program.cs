using System;

    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("enter a number: ");
        int n = 5;// int.Parse(Console.ReadLine());
        int start = 0;
        while (start<n)
        {
            Console.WriteLine(start);
            start += 2;
        }
        //////////////////////////////////////////////////
        Console.WriteLine("enter a number: ");
        start = 0;
        n = 5;//int.Parse(Console.ReadLine());
        do
        {
            Console.WriteLine(start);
            start += 2;
        } while (start < n);
       
        /* for*/
        int[,] arr4 ={ { 1, 2 },
                   { 2, 3 },
                   { 4, 5 }
                 };
                    Console.WriteLine(arr4.Length+" "+arr4.Rank+" "+arr4.Length/arr4.Rank);
                       for(int i = 0; i < 3; i++)
                    {
                        for(int j = 0; j < 2; j++)
                        {
                            Console.Write(arr4[i, j]);
                        }
                        Console.WriteLine();
                    }
        /* foreach */
        

                foreach (int temp in arr4)
                {
                    Console.Write(temp + " ");
                }
                  Console.WriteLine("break");
                   for(int i = 0; i < 20; i++)
                    {
                        Console.Write(i +" ");
                        if (i == 10)
                        {
                            break;
                        }
                    }
        Console.WriteLine();
               Console.WriteLine("continue");
                 for (int i = 0; i < 20; i++)
                    {
                        
                        if (i %2== 1)
                        {
                            continue;
                        }
                           Console.Write(i+" ");
        }

    }
    
    }

