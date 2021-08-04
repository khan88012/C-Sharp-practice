using System;

namespace parsetryparse
{
    class Program
    {
        static void Main(string[] args)
        {
      Console.WriteLine("enter a number which will be storing in a string to check parse ");
      string number = Console.ReadLine();
      try
      {
        int i = Int32.Parse(number);
        Console.WriteLine("the entered nubmer is "+ i);
      }
      catch (FormatException e)
      {
        Console.WriteLine("the entered value was not an integer thats why this exception is coming:      {0}", e.Message);
        Console.WriteLine( ); Console.WriteLine();

      }
      int j = 0;
      Console.WriteLine("enter a number which will be storing in a string to check tryparse");
      string number1 = Console.ReadLine();
      if (Int32.TryParse(number1,out j))
          {
        Console.WriteLine( "the number is {0}", j);
      }
      else
        Console.WriteLine("elese statement is executing : entered number is not in correct format");
        }
    }
}
