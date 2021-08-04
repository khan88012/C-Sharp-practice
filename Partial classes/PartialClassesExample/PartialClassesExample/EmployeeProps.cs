using System;
using System.Collections.Generic;
using System.Text;


namespace PartialClassesExample
{
  public partial class Employee
  {
    public int EmpId { get; set; }
    public string Name { get; set; }
    partial void GeneratedEmployeeid()
    {
      
      System.Random random = new System.Random();
      this.EmpId = random.Next(50);
      Console.WriteLine("id generated is ", this.EmpId);
    }
  }
}
