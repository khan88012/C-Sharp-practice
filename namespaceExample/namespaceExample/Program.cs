//namespaces do not correspond to file, directory or assembly names. they could be written in seprate files and or seperate assemblies and still belong to the same namespace.


using System;
using ProjectA.TeamB;
using ProjectA.TeamA;
using aliasToRemovePrrintMethodAmbiguity = ProjectA.TeamA;

namespace namespaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
      ProjectA.TeamA.ClassA.print();
    //  ClassA.print(); //ambiguity in print method

      aliasToRemovePrrintMethodAmbiguity.ClassA.print();
        }
    }
}

namespace ProjectA
{

  namespace TeamA
  {
    class ClassA
    {
      public static void print()
      {
        Console.WriteLine("team A print method");
      }
    }
  }
}
  namespace ProjectA
  {

    namespace TeamB
    {
      class ClassA
      {
        public static void print()
        {
          Console.WriteLine("team B print method");
        }
      }
    }
  }
