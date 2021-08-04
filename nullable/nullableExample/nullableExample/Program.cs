
//In C# types  are divided into 2 broad categories.
//Value Types  - int, float, double, structs, enums etc
//Reference Types – Interface, Class, delegates, arrays etc

//By default value types are non nullable. To make them nullable use ?

//Nullable types bridge the differences between C# types and Database types


using System;
namespace nullableExample
{
    class Program
    {
        static void Main(string[] args)
        {
      // int i = null; //throws error
      // Console.WriteLine("Print i=",i);



      int? j = null;  //legal
        Console.WriteLine("Print j=", j); //prints empty





    }
    }
}
