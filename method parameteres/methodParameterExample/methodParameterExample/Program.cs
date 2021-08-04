using System;

namespace methodParameterExample
{
    class Program
    {
        static void Main(string[] args)
        {
      int p = 0;
      int q = 123;
      callingThisMethod(out p , ref q,1,2,3,4,5,6);
      Console.WriteLine("out parameter p's value is {0} and ref parameter q's value is {1}",p,q);
        }

    private static void callingThisMethod(out int p,ref int k , params int [] parameterArray)
    {
      p = 10;
      k = 67;
      Console.WriteLine("content of params parameter are");
      foreach(int i in parameterArray)
      {
        Console.WriteLine(i);
      }
    }

   
  }
}
