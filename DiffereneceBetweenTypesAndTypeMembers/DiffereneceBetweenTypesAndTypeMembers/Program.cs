using System;
//in general classes, structs,enums, interfaces,delegates are called as types and fields, properties , constructors, methods etc., that are normally reside in  a type are called as type members
//in c# there are 5 different access modifiers: Private, Protected, Internal, Protected Internal and public
//Type members can have all the access modifiers, where as types can have only 2(internal, public )



//using regions you can expand and collaps sections of your code either manually, or using visual studio Edit->Outlining->Toggle all Outlining

namespace DiffereneceBetweenTypesAndTypeMembers
{
    class Program
    {
    #region Fields
    private string id;
    private string firstname;
    private string lastname;
    #endregion

    #region Properties
    public string Id { get => id; set => id = value; }
    public string Firstname { get => firstname; set => firstname = value; }
    public string Lastname { get => lastname; set => lastname = value; }
    #endregion
    #region Methods
    static void Main(string[] args)
        {
           
        }

    private void Fullname()
    {

    }
    #endregion
  }
}
