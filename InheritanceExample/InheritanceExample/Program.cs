using System;
//base classes are initiated before derived class
public class Employee
{
    public string FirstName;
    public string LastName;
    public string Email;

    public Employee()
    {
        Console.WriteLine("Parent class Constructor");
    }
    public Employee(string message)
    {
        Console.WriteLine("Parent class Constructor with the message : "+message);
    }
    public void PrintFullName()
    {
        Console.WriteLine("full name is {0} {1}",FirstName,LastName);
    }
}

public class FullTimeEmployee : Employee
{
    public float YearlySalary;
    public FullTimeEmployee(): base("Derived class controlling Parent class")//overloaded base class constructor

    {
        Console.WriteLine("Child class Constructor");
    }

}

public class ParTTimeEmployee : Employee
{
    public float HourlyRate;

}


namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "asif";
            FTE.LastName = "khan";
            FTE.YearlySalary = 700000;
            FTE.PrintFullName();
            Console.WriteLine();
            Console.WriteLine();
            ParTTimeEmployee PTE = new ParTTimeEmployee();
            PTE.FirstName = "Parttime";
            PTE.LastName = "Employee";
            PTE.HourlyRate = 700000;
            PTE.PrintFullName();
        }
    }
}
