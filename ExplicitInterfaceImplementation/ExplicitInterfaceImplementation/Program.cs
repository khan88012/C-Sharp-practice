using System;

//when two interfaces have same methods and is implemented in class which provides the implementation, the compiler doesnt give an error though there is ambiguity. we use Explicit interface implemenation here
//for explicit interface implementation remove access modier and add interface name before method name with a dot.
interface I1
{
    void InterfaceMethod();
}
interface I2
{
    void InterfaceMethod();
}

namespace ExplicitInterfaceImplementation
{
    class Program: I1,I2
    {
        static void Main(string[] args)
        {
            Program P = new Program();
          ((I1)P).InterfaceMethod();
            ((I2)P).InterfaceMethod();


            //or if u dont want to typecast
            I1 i1 = new Program();
            I2 i2 = new Program();
            i1.InterfaceMethod();
            i2.InterfaceMethod();

            //default interface method
            Program q = new Program();
            q.InterfaceMethod();
        }
       public void InterfaceMethod()
        {
            Console.WriteLine("default interface implementation");
        }

        void I1.InterfaceMethod()
        {
            Console.WriteLine( "I1 interface method");
        }
        void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 interface method");
        }
    }
}
