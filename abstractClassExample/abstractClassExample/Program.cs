using System;
//abstract classes is incomplete   hence cant be instantiated
//cant be sealed
//can only be used as base class
//abstract class may contain abstract members(methods , properties,  indexers and evenets), but not mandatory
//A non-abstract class derived from an abstract class must provide implementation for all inherited abstract members

//if a class inherits an abstract class, there are 2 options availabe for that class
//1-provide implementation for all
//2- do not want to provide for all declare abstract
 public abstract class Customer
{
    public abstract void Print();

    public void thisMethodWorks()
    {
        Console.WriteLine("Print from abstract calss with implementation");
    }
}

namespace abstractClassExample
{
    class Program : Customer
    {
        static void Main(string[] args)
        {
            Program P = new Program();
            P.Print();

            Customer C = new Program();//inheritance
            C.Print();
            C.thisMethodWorks();
        }

        public override void Print()
        {
            Console.WriteLine("overridedn print mehtod from the abstract customer class");
        }
    }
}
