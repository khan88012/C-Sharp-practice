using System;
 public delegate void RectangleDelegate(double Width, double Height);

namespace multicastDelegateExample
{
    class Program
    {
      public void GetArea(double Width, double Height)
    {
      Console.WriteLine(@"Area is {0}", (Width * Height));

    }
    public void GetPerimeter(double Width, double Height)
    {
      Console.WriteLine(@"Perimeter is {0}", (2 * (Width + Height)));
    }
    static void Main(string[] args)
        {
      Program rect = new Program();
      RectangleDelegate rectdelegate = new RectangleDelegate(rect.GetArea);
      Console.WriteLine("calling GetArea method using delegate");
      rectdelegate(10,20);

      Console.WriteLine("multicasting delegate for both GetArea and GetPerimeter");
      rectdelegate += rect.GetPerimeter;
      rectdelegate(30, 1);
      Console.WriteLine("calling with invoke functio   no diffrence");
      rectdelegate.Invoke(30, 1);
      Console.WriteLine("subtracted getPerimeter");
      rectdelegate -= rect.GetArea;
      rectdelegate(39,4);



    }
    }
}
