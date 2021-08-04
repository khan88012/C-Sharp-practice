using System;
using System.IO;
//The InnerException property returns the Exception instance that caused the current exception.
namespace InnerExceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
      try
      {
        try
        {
          Console.WriteLine("Enter First Number");
          int FN = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter Second Number");
          int SN = Convert.ToInt32(Console.ReadLine());


          int Result = FN / SN;
          Console.WriteLine("Result = {0}", Result);
        }
        catch(Exception innerTry)
        {
          string filePath = @"c:\Sample Files\log.txt";
          if(File.Exists(filePath))
          {
            StreamWriter sw = new StreamWriter(filePath);
            sw.Write(innerTry.GetType().Name + innerTry.Message + innerTry.StackTrace);
            sw.Close();
            Console.WriteLine("There is a problem! Please try later");
          }
          else
          {
            //To retain the original exception pass it as a parameter
            //to the constructor, of the current exception
            throw new FileNotFoundException(filePath + "Does not Exist", innerTry);
            
          }

        }

      }
      catch(Exception outerTry)
      {
        //outerTry.Message will give the current exception message
        Console.WriteLine("Outer Exception={0}", outerTry.Message);
        if(outerTry.InnerException!=null)
        {
          Console.WriteLine("inner Exception(innertry)={0}", outerTry.InnerException.Message);
        }

      }
        }
    }
}
