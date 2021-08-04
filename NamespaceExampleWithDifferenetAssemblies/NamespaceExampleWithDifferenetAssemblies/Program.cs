using System;
using A=ProjectA.TeamA;
using B= ProjectA.TeamB;



//right click on solution go to open in folder u ll find different assemblies for each namespace


namespace NamespaceExampleWithDifferenetAssemblies
{
  class Program
  {
    static void Main(string[] args)
    {
      B.ClassA.print();

      //A.ClassA.print(); classA protection is private 
    }
  }
}

