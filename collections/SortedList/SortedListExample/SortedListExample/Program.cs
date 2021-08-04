using System;
using System.Collections.Generic;
//C# SortedList<TKey, TValue> is an array of key/value pairs.
//SortedList<TKey, TValue> class uses less memory than SortedDictionary<TKey, TValue>. It is recommended to use SortedList<TKey, TValue> if you have to store and retrieve key/valye pairs.
//The SortedDictionary<TKey, TValue> class is faster than SortedList < TKey, TValue > class if you perform insertion and removal for unsorted data.
namespace SortedListExample
{
    class Program
    {
        static void Main(string[] args)
        {
      SortedList<string, string> names = new SortedList<string, string>();
      names.Add("1", "Sonoo");
      names.Add("4", "Peter");
      names.Add("5", "James");
      names.Add("3", "Ratan");
      names.Add("2", "Irfan");
      foreach (KeyValuePair<string, string> kv in names)
      {
        Console.WriteLine(kv.Key + " " + kv.Value);
      }

      names.Remove(Convert.ToString(2));
      foreach (KeyValuePair<string, string> kv in names)
      {
        Console.WriteLine(kv.Key + " " + kv.Value);
      }
    }
    }
}
