using System;
interface ICustomer
{
    //interface members are public by default  and cannot have expplict access modifier
    void Print();//cannot have an implementation
                 // int i; cannot contain instance variable

   
}
interface I2
{
    void methodI2();
}

class Customer : ICustomer,I2  //multiple interface inheritance     multiple classes cant be inherited at one time
{
    public void methodI2()
    {
        Console.WriteLine("interface i2");
    }

    public void Print()
    {
        Console.WriteLine("Inerface implementation of print method!");
    }
}

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer obj = new Customer();
            obj.Print();


            ICustomer obj1 = new Customer();  //we cannot create intstance of an interface but an interface refrence  variable can point to a derived class object
            obj1.Print();

            I2 obj2 = new Customer();
            obj2.methodI2();
        }
    }
}
