using System;
/*
 Abstract classes can have implementations for some of its members(Methods), but the interface cant have implementation for any of tis members.
Interface cant have fields where as an abstract class can have fields.
An interface can inherit from another interface only and cant inherit form an abstract class, whrereas an abstract class can inherit form another abstract class or another interface.
A class can inherit form multiple interfaces at the same time, whereas a class cant inherit form mulitile classes at the same time.
Abstract class members can have access modifiers whrereas interface memebers cnt have access modifiers.
defalut access modifier is private for abstract classes  and for interface it is public  though u cant put it explicitlye
 */

public abstract class Customer
{
    int ID;
    public void Print()
    {
        Console.WriteLine("Print");
    }
}
public abstract class Customer1:Customer,ICustomer
{
    int ID;
    public void Print()
    {
        Console.WriteLine("Print");
    }
}
public interface  ICustomer2
{
    //int ID;// violation
    void Print();
}
public interface ICustomer :ICustomer2  // ,Customer //violation
{
    //int ID;// violation
    void Print();
}
namespace diffrenceBetweenAbstractClassesAndInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
