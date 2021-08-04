using System;
using System.Collections.Generic;
//hashset stores distinct element, example with add and initializer, demo for adding removing checking using contains method
namespace HashSetExample
{
    class Program
    {
        static void Main(string[] args)
        {
      var names = new HashSet<string>();
      names.Add("Sonoo");
      names.Add("Ankit");
      names.Add("Peter");
      names.Add("Irfan");
      names.Add("Ankit");//will not be added


      foreach(string name in names )
      {
        Console.WriteLine(name);
      }
      Console.WriteLine( );
      //with initializer
      var names1 = new HashSet<string>() { "Sonoo", "Ankit", "Peter", "Irfan", "Sonoo", "Ankit", "Peter", "Irfan" };
      foreach (string name in names1)
      {
        Console.WriteLine(name);
      }
      
      Console.WriteLine("Enter name to remove from hashset");
      string nametoremove = Console.ReadLine();
      //remove elements
      if (names1.Contains(nametoremove)&&names1.Remove(nametoremove))
      {
        Console.WriteLine(nametoremove+" , is removed from the hashset");
      }
      else
        Console.WriteLine("not present cant be removed");

      Console.WriteLine(  "after removing the name new hashset is ");
      foreach (string name in names1)
      {
        Console.WriteLine(name);
      }

      Console.WriteLine("number of elements after removing the name="+ names1.Count);
    }
    }
}
