using System;
using System.Collections.Generic;

namespace LinkedListExample
{
    class Program
    {
    static void Main(string[] args)
    {


      var names = new LinkedList<string>();
      names.AddLast("Sonoo Jaiswal");
      names.AddLast("Ankit");
      names.AddLast("Peter");
      names.AddLast("Irfan");
      names.AddFirst("John");//added to first index
                             //

      string[] copy = new string[names.Count];// creating an array to copy elements from linked list




      // Iterate list element using foreach loop  
      foreach (var name in names)
      {
        Console.WriteLine(name);
      }
      LinkedListNode<string> findit = names.Find("Peter");
      Console.WriteLine("first node with element  {0} has been found ", findit.Value);



      names.CopyTo(copy, 0);// copying the element


      Console.WriteLine("after copying to an array");
      foreach (var name in copy)
      {
        Console.WriteLine(name);
      }
      LinkedListNode<string> addafterthisnode = names.AddFirst(" addafterthisnode");
      names.AddAfter(addafterthisnode, "addaftermethod"); // there are two overloads of this method one takes both argument as linked list node   another takes firstargument as linkedlist node and second argument as only type  here string
      Console.WriteLine("linked list after the AddAfter(addafterthisnode, \"addaftermethod\" method");
      foreach (var name in names)
      {
        Console.WriteLine(name);
      }
      Console.WriteLine("enter name to check in the list");
      string contains = Console.ReadLine();

      if (names.Contains(contains))
        Console.WriteLine("{0} is presenet in the linkedlist", contains );
        ;
      names.Clear();
      Console.WriteLine("list is cleared using names.Clear() method");
    }
    }
}
