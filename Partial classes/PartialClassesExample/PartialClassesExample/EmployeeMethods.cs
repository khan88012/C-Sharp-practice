//Rules for Partial Classes
//All the partial class definitions must be in the same assembly and namespace.
//All the parts must have the same accessibility like public or private, etc.
//If any part is declared abstract, sealed or base type then the whole class is declared of the same type.
//Different parts can have different base types and so the final class will inherit all the base types.
//The Partial modifier can only appear immediately before the keywords class, struct, or interface.
//Nested partial types are allowed.




using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClassesExample
{
  public partial class Employee
  {
    public Employee(int id, string name)
    {
      this.EmpId = id;
      this.Name = name;
    }

    public void DisplayEmpInfo()
    {
      Console.WriteLine(this.EmpId + " "+ this.Name);
      GeneratedEmployeeid();//calling partial method
    }

    //Partial method
     partial void GeneratedEmployeeid();
  }
}
