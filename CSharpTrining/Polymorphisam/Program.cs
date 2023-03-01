using System;

public class BaseC
{
    public virtual void Dispay()
    {
        Console.WriteLine("i am base");
    }
}
public class Derive:BaseC
{
    public override void Dispay()// public new void Dispay()// public void Dispay()

    {
        Console.WriteLine("i am derive");
    }
}

    class Program
    {
    static void Fun(int x)
    {
        Console.WriteLine(x);
    }
    static void Fun(int x,int y)
    {
        Console.WriteLine(x+y);
    }
    static void Main(string[] args)
        {
                 BaseC obj1 = new BaseC();
                   obj1.Dispay();
        BaseC obj2 = new Derive();
        obj2.Dispay();
        Fun(3);
        Fun(3, 4);
        }   
    }

