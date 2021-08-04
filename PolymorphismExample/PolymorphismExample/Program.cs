using System;
//definition of polymorphism
//polymorphism lets you invoke derive class methods by base calss refrence variable at runtime 
public class Employee
{
    public string Firstname="FN";
    public string Lastname="LN";
    public virtual void PrintFullName()
    {
        Console.WriteLine(Firstname + " " + Lastname );
    }
}

public class PartTimeEmployee: Employee
{ 
    //just type override hit space bar      the intellisense will show virtual methods to override
      
    public override void PrintFullName()
    {
        Console.WriteLine(Firstname + " " + Lastname + "- Part Time");
    }
}
public class FullTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(Firstname + " " + Lastname+" - Full Time");
    }
}
public class TemporaryEmployee : Employee
{
    public override void PrintFullName()
    {
       // Console.WriteLine(Firstname + " " + Lastname + " - temporary");
    }
}
namespace PolymorphismExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];
            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();  //without override base class printfullname will run   becasus of being parent calss refrence
            employees[2] = new FullTimeEmployee();
            employees[3] = new TemporaryEmployee();

            foreach(Employee e in employees)
            {
                e.PrintFullName();
            }
        }
    }
}
