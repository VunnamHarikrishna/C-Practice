using System;

namespace StaticAndInstance
{
    class Circle
    {
      static  float _PI = 3.14f;
        int _radius;
        public int ID { get; set; } 
        public float area(int r)
        {
            _radius = r;
            return _PI * _radius * _radius;
        }
       public static float areas(int r)
        {
          Circle obj = new Circle();

           obj. _radius = r;
            return  _PI *obj. _radius *obj. _radius;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle ob = new Circle();
           float res= ob.area(int.Parse(Console.ReadLine()));
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
