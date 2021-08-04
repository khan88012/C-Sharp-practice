using System;
/// <summary>
/// Private members are available only within the containing type.
/// Protected members are available within the containing type and to the types that derive from the containing type
/// Public members are available anywhere
/// </summary>
namespace PublicProtectedPrivate
{
    class Program
    {
    access accessfromProgramclass = new access();
    static void Main(string[] args)
        {
      access accessfromProgramclass = new access();
      // accessfromProgramclass._privatedata;           //cannot access _privatedata as this is an another class

     // accessfromProgramclass.protecteddata;         //since Program class is not inheriting access class it cannot access protecteddata
        }
    }


  class accessProtected : access
  {
       public void print()
    {
      accessProtected obj = new accessProtected();
      Console.WriteLine(obj.protecteddata);    //protecteddata can be accessed
      base.protecteddata = 3424;
      this.protecteddata = 343;
    }
  
  }
  class access
  {
    private int _privatedata;
    protected int protecteddata;
    public int _Private
    {
      get
      {
        return _privatedata;   //within class youcan access _privatedata
      }
      set
      {
        _privatedata = value;

      }
    }

  }
}
