using System;

//we are using getter and setter method to access private fields and also controlling write and read 
public class Student
{
    private int _ID;  //private field convetion prefix with an underscore
    private String _Name;
    private int _PassMark = 35;
    //

    public string Email { get; set; }  //auto implement properties when used, compiler creates a private , anonymous field that can only be accessed through property' s get and set accessors
    public int Id
    {
        set
        {
            if (value <= 0) //value is keyword takes value for set
            {
                throw new Exception("student id cannot be negative");
            }
            this._ID = value;
        }
        get
        {
            return this._ID;
        }
    }
    public string name
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Name cannot be null or empty");
            }
            this._Name = value;
        }
        get
        {
            return this._Name;
        }
    }
    public int passMark
    {
        get
        {
            return this._PassMark;
        }
        
    }
}

namespace CSharpPropertyGetSet
{
    class Program
    {
      public  static void Main(string[] args)
        {
            Student s1 = new Student();
            // s1.SetID(-101);
            s1.name = "asif";
            s1.Id = 101;
            Console.WriteLine("Student Id = {0}", s1.Id);
            // s1.SetName(null);
            Console.WriteLine("stufent name ={0}", s1.name);
            Console.WriteLine("Passing marks ={0}", s1.passMark);
            s1.Email = "asifkhan88012@gmail.com";
            Console.WriteLine(s1.Email);
        }
    }
}

