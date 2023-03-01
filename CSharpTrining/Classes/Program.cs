using System;


class Customer
{
    string _firstName;
    string _lastname;
   public Customer(string FName,string LName)
    {
        this._firstName = FName;
        this._lastname = LName;
    }

   public void Display()
    {
        Console.WriteLine(_lastname + "  " + _firstName);
    }
}
    class Program
    {
        static void Main(string[] args)
        {
        
        Customer obj = new Customer("hari","krishna");
        obj.Display();

        }
    }

