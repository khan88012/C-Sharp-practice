using System;
using System.Collections.Generic;
//list with initializer and add method
namespace AddingElementToAList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
      names.Add("My");
      names.Add("\tname");
      names.Add("\tis");
      names.Add("\tAsif.");
      foreach(string name in names)
      {
        Console.Write(name);
      
      }
      Console.WriteLine();
      //another way using collection initializer
      var names1 = new List<string>() { "asif", "mister","Somu","etc"};

      foreach (string name in names1)
      {
        Console.WriteLine(name);
      }


    }
    }
}
