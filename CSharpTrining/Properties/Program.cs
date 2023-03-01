using System;

namespace Properties
{
    class Student
    {
        int _id;
        string _name;
        int _marks = 99;
        // public int Marks { get; }
        public int MyProperty { get; set; }
        public int Marks
        {
            get
            {
                return this._marks;
            }
        }
        public int ID
        {
            set
            {
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }
         //public int GetMarks()
        //{
            
        //    return this.marks;
        //}
        //public void setId(int id)
        //{
        //    if (id <= 0)
        //    {
        //        throw new Exception("studnt is must greater then 0");
        //    }
        //    this._id = id;
        //}
        //public int GetID()
        //{
        //    return this._id;
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student obj = new Student();
            obj.ID = 23;
            Console.WriteLine(obj.ID
                +" "+obj.Marks);
        }
    }
}
