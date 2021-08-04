using System;
using System.Collections.Generic;

namespace SortedSetExample
{
    class Program
    {
    static void Main(string[] args)
    {
      var names = new SortedSet<string>();
      names.Add("Sonoo");
      names.Add("Ankit");
      names.Add("Peter");
      names.Add("Irfan");
      names.Add("Ankit");//will not be added


      foreach (string name in names)
      {
        Console.WriteLine(name);
      }
      Console.WriteLine();
      //with initializer
      var names1 = new SortedSet<string>() { "Sonoo", "Ankit", "Peter", "Irfan", "Sonoo", "Ankit", "Peter", "Irfan" };
      foreach (string name in names1)
      {
        Console.WriteLine(name);
      }

      Console.WriteLine("Enter name to remove from SortedSet");
      string nametoremove = Console.ReadLine();
      //remove elements
      if (names1.Contains(nametoremove) && names1.Remove(nametoremove))
      {
        Console.WriteLine(nametoremove + " , is removed from the SortedSet");
      }
      else
        Console.WriteLine("not present cant be removed");

      Console.WriteLine("after removing the name new SortedSet is ");
      foreach (string name in names1)
      {
        Console.WriteLine(name);
      }

      Console.WriteLine("number of elements after removing the name=" + names1.Count);
    }
  }
}


