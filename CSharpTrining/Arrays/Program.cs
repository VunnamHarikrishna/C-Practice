using System;



    class Program
    {
        static void Main(string[] args)
        {
        int[] arr = {1,2,3,4,5,6,7};
        int[] arr2 = new int[] {1,2,3,4,5,6 };
        int[] arr3 = new int[1];
        arr3[0] = 1;
       // arr3[1] = 2; this is not posible
        Console.WriteLine(arr3[0]+" \n"+arr.Length+"\n"+arr.Rank);
        foreach(int temp in arr)
        {
            Console.Write(temp+" ");
        }
        Console.WriteLine();
        /////2D array
        int[,] arr4={ { 1, 2 },
                      { 2, 3 },
                      { 4, 5 }
                                 };
        
        foreach(int temp in arr4)
        {
            Console.Write(temp + " ");
        }
        Console.WriteLine("------------------------------");
        //3D array
        int[,,] arr5 = new int[2, 3, 4]
        {

            {  
                {1,1,1,1 },{1,1,1,1 },{1,1,1,1 }
            },
            {  
                {2,2,2,2 },{2,2,2,2 },{2,2,2,2 }
            }
        };

        for(int i = 0; i < 2; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                for(int k = 0; k < 4; k++)
                {
                    Console.Write(" "+arr5[i,j,k]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        Console.WriteLine("--------------------------------");
        int[][,] arr6 = new int[3][,]
        {
            new int[2,2]{ {1,2 },{1,2 } },
            new int[,]{ {3,4 },{3,4 } },
            new int[,]{ {5,6 },{5,6 } }
        };
            for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 2; j++)
            {
                for(int k = 0; k < 2; k++)
                {
                    Console.Write(" " + arr6[i][j, k]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(".");
        }

        }
    }

