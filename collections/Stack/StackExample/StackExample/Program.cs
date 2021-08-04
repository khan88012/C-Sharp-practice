using System;
using System.Collections.Generic;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
      Stack<string> names = new Stack<string>();
      names.Push("asif");//push stores element on top
      names.Push("Sonoo");
      names.Push("Peter");
      names.Push("James");
      names.Push("Ratan");
      names.Push("Irfan");// right now Irfan is on top
      foreach (string name in names)
      {
        Console.WriteLine(name);
      }
      //pop removes the top element
      string poppedElement = names.Pop();
      Console.WriteLine("Popped element is = {0}", poppedElement );
      Console.WriteLine("Pop removes the element on the top\n after popping the left stack:");
      foreach (string name in names)
      {
        Console.WriteLine(name);
      }
      //peek method lets you check the element on top and returns the string

      Console.WriteLine( "the element on top of the stack is  "+ names.Peek());

    }
    }
}
