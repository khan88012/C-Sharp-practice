using System;
//A struct is a value type where as a class is  a refrence type.
//Structs are stored on stack , whereas classes are stored in heap.
//Value types hold their value in stack memory where they are declared , but refrence types hold a refrence to an object in stack memory but actual object is stored in heap.
//Value types are destroyed immediately after the scope is lost, whereas for refrence types, only the refrence variable is destroyed after the scope is lost. The object is later destroyed by garbage collector.

//when you copy a struct into another struct , a new copy of that struct gets created and modifications on one struct wil not affect the value contained by the other sturct.

//structs cant have destructors, but classes can have destructors.
//structs cant have explicit parameter less constructor whrere as a class can
//struct cant inherit from another class where as a class can, both structs and class can inherit form an interface
struct CopyStruct
{

    private int i;
    private int j;

    //public CopyStruct()
    //{

    //}
    public CopyStruct(int I,int J)
    {
        this.i = I;
        this.j = J;

    }

    public int I { get => i; set => i = value; }
    public int J { get => j; set => j = value; }

    public void print()
    {
        Console.WriteLine("i={0} and j={1}", I, J);
    }
    //~CopyStruct()
    //{

    //}
}
class CopyClass
{

    private int i;
    private int j;
    public CopyClass(int I, int J)
    {
        this.i = I;
        this.j = J;

    }

    public int I { get => i; set => i = value; }
    public int J { get => j; set => j = value; }

    public void print()
    {
        Console.WriteLine("i={0} and j={1}", I, J);
    }
    ~CopyClass()
    {

    }
}
namespace differenceBetweenStructAndClass
{
    class Program
    {
        static void Main(string[] args)
        {
            CopyStruct first = new CopyStruct(1,2);
            Console.WriteLine(  "content of first structure");
            first.print();
            CopyStruct Second = new CopyStruct();

            Second = first;
            Console.WriteLine("content of second structure");
            Second.print();

            first.I = 3;
            first.J = 4;
            Console.WriteLine("after modifications in first structure content of first structure:  ");
            first.print();

            Console.WriteLine( "content of second structure");
            Second.print();
            Console.WriteLine();
            Console.WriteLine();

            CopyClass firstobj = new CopyClass(1, 2);
            Console.WriteLine("content of first Class object");
            firstobj.print();
            CopyClass Secondobj;
            Console.WriteLine("content of Second Class object");
            Secondobj = firstobj;
            Secondobj.print();
            firstobj.I = 3;
            firstobj.J = 4;
            Console.WriteLine("after modifications in first class object content of first class object:  ");
            firstobj.print();

            Console.WriteLine("content of second Class object");
            Secondobj.print();
        }
    }
}
