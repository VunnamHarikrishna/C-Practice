using System;


public class Emp
{
    public string Fname;
    public string Lname;
    public string Email;
   //public Emp()
   // {
   //     Console.WriteLine("hello emp");
   // }
    public void PrintFName()
    {
        Console.WriteLine(Fname + " " + Lname);
    }

}
public class FullTimeEmp : Emp
{
    public float sal;
    public void PrintFName()
    {
        Console.WriteLine(Fname + " == " + Lname);
    }
  
}
public class PartTimeEmp : Emp
{
    public float hourpay;
}
class Program
    {
        static void Main(string[] args)
        {
        FullTimeEmp FTE = new FullTimeEmp();
        FTE.Fname = "Hari";
        FTE.Lname = "Krisna";
        FTE.PrintFName();
        PartTimeEmp PTE = new PartTimeEmp();
        PTE.Fname = "HH";
        PTE.Lname = "dfv";
        Emp obj = new PartTimeEmp();
      //  obj.hourpay = 55; this will make error
        PTE.PrintFName();
        }
    }
