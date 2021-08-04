using System;
//Enums are strongly typed constants.
//  if a program uses set of integral numbers, consider replacing them with enums, otherwise the program becomes less readable and maintainable.
//Enums are value type


namespace EnumExample1
{
    class Program
    {
        static void Main(string[] args)
        {
      Customer[] customers = new Customer[3];
      customers[0] = new Customer()
      {
        Name = "Mark",
        gender = Gender.Male
      };
      customers[1] = new Customer()
      {
        Name = "Mary",
        gender = Gender.Female
      };
      customers[2] = new Customer()
      {
        Name = "Sam",
        gender = Gender.Unknown
      };

      foreach (Customer customer in customers)
      {
        Console.WriteLine("Name = {0} && Gender = {1}", customer.Name, GetGender(customer.gender));
      }


    }

    public static string GetGender(Gender gender)
    {
      switch (gender)
      {
        case Gender.Unknown:
          return "Unknown";
        case Gender.Male:
          return "Male";
        case Gender.Female:
          return "Female";
            default:
          return "invalid";
      }
    }
    }

  public enum Gender
  {
    Unknown,
    Male,
    Female
  }

  public class Customer
  {
    public string Name { get; set; }
    public Gender gender { get; set; }
  }
}
