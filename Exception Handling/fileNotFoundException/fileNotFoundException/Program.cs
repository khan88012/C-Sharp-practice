using System;
using System.IO;

namespace fileNotFoundException
{
    class Program
    {
        static void Main(string[] args)
        {
      StreamReader streamReader = null;
      try
      {
        streamReader = new StreamReader("C:\\NonExistingFile.txt");
        Console.WriteLine(streamReader.ReadToEnd());
      }
      catch(FileNotFoundException fileNotFoundException)
      {
        Console.WriteLine("Please check if the file {0} is present ", fileNotFoundException.FileName);
      }
      catch(Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
      finally
      {
        if (streamReader != null)
          streamReader.Close();
      }
            
        }
    }
}
