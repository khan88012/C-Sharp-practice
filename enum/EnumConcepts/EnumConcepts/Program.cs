using System;

namespace EnumConcepts
{
    class Program
    {
        static void Main(string[] args)
        {



      // This line will not compile. Cannot implicitly convert type 'Season' to 'Gender'. 
      // An explicit conversion is required.
      // Gender gender = Season.Winter;


      // This line comiples as we have an explicit cast
      Gender gender = (Gender)Season.Winter;






      int[] values = (int[])Enum.GetValues(typeof(Gender));
           foreach(int val in values)
           {
              Console.WriteLine(val);
           }
      string[] Names = (string[])Enum.GetNames(typeof(Gender));
      foreach (string name in Names)
      {
        Console.WriteLine(name);
      }
    }
    }

  public enum Gender // :short // (u can change underlying data type of enum    default is int)
  {
    Unknown,  // Unknown =1,  //is possible
    Male,
    Female
  }

  public enum Season : int
  {
    Winter = 1,
    Spring = 2,
    Summer = 3
  }
}
