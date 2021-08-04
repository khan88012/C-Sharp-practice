using System;
//we are using getter and setter method to access private fields and also controlling write and read 
public class Student
{
    private int _ID;  //private field convetion prefix with an underscore
    private String _Name;
    private int _PassMark = 35;

    public int GetPassMark()
    {
        return this._PassMark;
    }


    public void SetName(string name)
    {
        if(string.IsNullOrEmpty(name))
        {
            throw new Exception("Name cannot be null or empty");
        }
    }
    public string GetName()
    {
        return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
       
    }

    public void SetID(int Id)
    {
        if(Id<=0)
        {
            throw new Exception("student id cannot be negative");
        }
        this._ID = Id;
    }
    public int GetID()
    {
        return this._ID;
}
}

namespace PropertiesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            // s1.SetID(-101);

            s1.SetID(101);
            Console.WriteLine("Student Id = {0}", s1.GetID());
           // s1.SetName(null);
            Console.WriteLine("stufent name ={0}", s1.GetName());
            Console.WriteLine("stufent name ={0}", s1.GetPassMark());
        }
    }
}
