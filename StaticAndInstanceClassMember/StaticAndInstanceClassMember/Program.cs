using System;
class Circle
{
  //float _PI = 3.141F;//for every instance of the class it is created again and again
  static float _PI;
  int _Radius;
  static Circle()
  {
    //initializes static members only
    Circle._PI = 3.14F;
    Console.WriteLine("static constructor runs before anything");
  }
  public Circle(int Radius)
      {
    this._Radius = Radius;
  }
  public float CalculateArea()
  {
    // return this._PI * this._Radius * this._Radius;//this keyword refrence the instance 
    return _PI * this._Radius * this._Radius;// u can use  Circle._Pi also 
  }
}

namespace StaticAndInstanceClassMember
{
    class Program
    {
        static void Main(string[] args)
        {
      Circle C1 = new Circle(5);
      float Area = C1.CalculateArea();
      Console.WriteLine("Area={0}",Area);


      Circle C2 = new Circle(6);
      float Area2 = C2.CalculateArea();
      Console.WriteLine("Area={0}", Area2);
    }
    }
}
