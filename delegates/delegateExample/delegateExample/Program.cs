using System;
//In C#, delegate is a reference to the method. It works like function pointer in C and C++. But it is objected-oriented, secured and type-safe than function pointer.
//A delegate is a type safe function pointer.That is, they hold reference(Pointer) to a function. 


//The signature of the delegate must match the signature of the function, the delegate points to, otherwise you get a compiler error. This is the reason delegates are called as type safe function pointers.


//A Delegate is similar to a class. You can create an instance of it, and when you do so, you pass in the function name as a parameter to the delegate constructor, and it is to this function the delegate will point to.


//Tip to remember delegate syntax: Delegates syntax look very much similar to a method with a delegate keyword.

delegate int Calculator(int n);
namespace delegateExample
{
    class Program
    {
    static int number = 100;
    public static int add(int n)
    {
      number = number + n;
      return number;
    }
    public static int mul(int n)
    {
      number = number * n;
      return number;
    }
    public static int sub(int n)
    {
      number = number - n;
      return number;
    }
    public static int getNumber()
    {
     
      return number;
    }

    static void Main(string[] args)
        {
      Calculator c1 = new Calculator(add);
      c1(20);// 100+20=120
      Console.WriteLine("c1 delegate for add"+getNumber());
      Calculator c2 = new Calculator(mul);
      c2(2);// 120*2=240
      Console.WriteLine("c2 delegate for mul" + getNumber());

      Calculator c3 = new Calculator(sub);
      c3(40);// 240-40=200
      Console.WriteLine("c3 delegate for sub" + getNumber());
     
    }
    }
}
