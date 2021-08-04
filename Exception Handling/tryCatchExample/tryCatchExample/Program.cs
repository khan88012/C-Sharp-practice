using System;

namespace tryCatchExample
{
    class Program
    {
        static void Main(string[] args)
        {
      //int a = 10;
      //int b = 0;
      //int x = a / b;        //exception so the rest of the code wont run
      //Console.WriteLine("Rest of the code");


      // exception :Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.
      // at tryCatchExample.Program.Main(String[] args) in C: \Users\khanm36\OneDrive - Medtronic PLC\Desktop\C#\Exception Handling\tryCatchExample\tryCatchExample\Program.cs:line 11


      try
      {
        int a = 10;
        int b = 0;
        int x = a / b;
      }
      catch (Exception e)
      {

        Console.WriteLine("the exception caught is:\n"+e);
      }
      Console.WriteLine("Rest of the code");

    }
    }
}
