using System;
using System.Collections.Generic;

namespace queueExample
{
  class Program
  {
    static void Main(string[] args)
    {
      Queue<string> names = new Queue<string>();
      names.Enqueue("asif");//Enqueue stores element on front in the queue
      names.Enqueue("Sonoo");
      names.Enqueue("Peter");
      names.Enqueue("James");
      names.Enqueue("Ratan");
      names.Enqueue("Irfan");// right now Irfan is on last in the queue
      foreach (string name in names)
      {
        Console.WriteLine(name);
      }
      //pop removes the top element
      string poppedElement = names.Dequeue();
      Console.WriteLine("dequed element is = {0}", poppedElement);
      Console.WriteLine("deque removes the element from the front\n after dequeing the left Queue:");
      foreach (string name in names)
      {
        Console.WriteLine(name);
      }
      //peek method lets you check the element on top and returns the string

      Console.WriteLine("now the element in the front  of the Queue is  " + names.Peek());

    }
  }
}
