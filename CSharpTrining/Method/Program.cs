using System;


 class Program
    {
        static void Main()
        {
        Program obj = new Program();
        int n = int.Parse(Console.ReadLine());
       obj. EvenNum(n);
        Console.WriteLine();
        EvenNum2(ref n);
        Console.WriteLine(n);

        int[] ar = {1,2,2,3,4,5 };
        Paramsmethod();//if we use params key word it accepts if you don't pass parameters 
        Paramsmethod(ar);
        Paramsmethod(11, 2, 3, 4, 5, 6, 7, 8, 9);

        Console.ReadLine();
        }
    /// <summary>
    ///                    this is for call by value
    /// </summary>
    /// <param name="n"></param>
        public void EvenNum(int n)
        {
            
            for(int i = 0; i < n;i+=2)
            {
                Console.Write(" " + i);
            }

        }
    /// <summary>
    ///                this is by reference
    /// </summary>
    /// <param name="n"></param>
    public static void EvenNum2(ref int n)
    {
        n = 123;

    }
    /// <summary>
    ///                   out parameter
    /// </summary>
    /// <param name="n"></param>
    /// <param name="m"></param>
    /// <param name="sum"></param>
    /// <param name="pro"></param>
    static void Outpara(int n,int m,out int sum,out int pro)
    {
        sum = n + m;
        pro = n * m;
    }
    /// <summary>
    ///               this is params method or array method
    /// </summary>
    /// <param name="arr"></param>
    static void Paramsmethod(params int[] arr)//static void Paramsmethod(params int[] arr,int X) this is not work
    {
        Console.WriteLine(arr.Length);
    }
    
}

