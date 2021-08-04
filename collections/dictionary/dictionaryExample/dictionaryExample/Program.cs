using System;
using System.Collections.Generic;


//C# Dictionary<TKey, TValue> class uses the concept of hashtable. It stores values on the basis of key. It contains unique keys only. By the help of key, we can easily search or remove elements.
namespace dictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
      Dictionary<int, string> names = new Dictionary<int, string>();

      names.Add(2, "Sonoo");
      names.Add(6, "Peter");
      names.Add(4, "Ratan");
      names.Add(5, "Irfan");
      names.Add(3, "James");
      names.Add(1, "Ratan");
      names.Add(0, "Irfan");

      foreach (KeyValuePair<int, string> kv in names)
      {
        Console.WriteLine("key="+kv.Key+"value="+kv.Value);
      }

      int capacity = names.EnsureCapacity(454343457);//couldnt understand
      Console.WriteLine( "the current capacity of dictionary is ={0}", capacity);

      //C# SortedDictionary<TKey, TValue> class uses the concept of hashtable. It stores values
      //on the basis of key. It contains unique keys and maintains ascending order on the basis of
      //key. By the help of key, we can easily search or remove elements. It is found in System.Collections.Generic namespace.

      SortedDictionary<int, string> names1 = new SortedDictionary<int, string>();

      names1.Add(2, "Sonoo");
      names1.Add(6, "Peter");
      names1.Add(4, "Ratan");
      names1.Add(5, "Irfan");
      names1.Add(3, "James");
      names1.Add(1, "Ratan");
      names1.Add(0, "Irfan");
      Console.WriteLine("dictionary is presented in sorted matter");
      foreach (KeyValuePair<int, string> kv in names1)
      {
        Console.WriteLine("key=" + kv.Key + "value=" + kv.Value);
      }

    }
  }
}
