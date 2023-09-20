﻿using System;

namespace Shape
{
  class Program
  {
    static void Main(string[] args)
    {
      // Shape Test
      Shape shape = new Shape();
      Console.WriteLine(shape);

      shape = new Shape("red", false);
      Console.WriteLine(shape);

      // Circle Test
      Circle circle = new Circle();
      circle.Resizeable(30);
      Console.WriteLine(circle);

      circle = new Circle(3.5);
      circle.Resizeable(30);
      Console.WriteLine(circle);

      circle = new Circle(3.5, "indigo", false);
      circle.Resizeable(30);
      Console.WriteLine(circle);
      
    
      // Square Test
      Square square = new Square();
      Console.WriteLine(square);
      square.HowtoColor();  
      square = new Square(2.3);
      Console.WriteLine(square);
      square.HowtoColor();  
      square = new Square(5.8, "yellow", true);
      Console.WriteLine(square);
      square.HowtoColor();
    }
  }
}