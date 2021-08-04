using System;

public class Employee
{
    public string Firstname;
    public string Lastname;
    public void PrintFullName()
    {
        Console.WriteLine(Firstname+ " " + Lastname+ " Parent");
    }
}

public class PartTimeEmployee : Employee
{
    
}
public class FullTimeEmployee : Employee
{
    public new  void PrintFullName() //hides the employee PrintFullName      use new keyword  for hiding    not using new will give a warnig
    {
        base.PrintFullName();//calls base printfullname
        Console.WriteLine(Firstname + " " + Lastname +" child");
    }
}

namespace methodHidingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.Firstname="FullTime";
            FTE.Lastname = "Employee";
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.Firstname = "PartTime";
            PTE.Lastname = "Employee";
            PTE.PrintFullName();//prints child class printfullname


           ((Employee) PTE).PrintFullName();//explicit calling of base printfullname by typecasting


            Employee PTE1 = new PartTimeEmployee();//refrence variable of employee(parent class) PTE1
            PTE1.Firstname = "PartTime";
            PTE1.Lastname = "Employee";
            PTE1.PrintFullName();//PTE1 is printing employee printfullname
        }
    }
}
