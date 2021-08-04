using System;
using System.Collections.Generic;
//we want to promote employees based on some criteria like experience greater than  5 years

namespace DelegateKudvenkatExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee { ID = 101, Name="mark", Experience=1, Salary=9000});
            emplist.Add(new Employee { ID = 102, Name = "mary", Experience = 2, Salary = 5000 });
            emplist.Add(new Employee { ID = 103, Name = "anthony", Experience = 2, Salary = 4000 });
            emplist.Add(new Employee { ID = 104, Name = "tony", Experience = 8, Salary = 6000 });

            IsPromotable promotable = new IsPromotable(Promote);
            
           Employee.PromoteEmployee(emplist,promotable);
            //we can use lambda function, lambda functions are based on delegates     compiler behind the scene will do all this stuff like creating a delegate   writing a function   passing it into dleegate
            Employee.PromoteEmployee(emplist, emp=> emp.Salary>=7000);
        }
        public static  bool Promote(Employee emp) //any logic can be written
        {
            if(emp.Experience>=5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


   
    
    
    delegate bool IsPromotable(Employee empl);
   
    
    
    
    
    
    
    
    class Employee
    {
       public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable isEligiableToPromote)//passing a delegate as a parameter
        {
            foreach(Employee employee in employeeList)
            {
                if(isEligiableToPromote(employee))
                    Console.WriteLine("{0} is promoted", employee.Name);
            }
        }
    }
}
