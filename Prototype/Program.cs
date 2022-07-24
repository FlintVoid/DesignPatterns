using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Creational.Prototype
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            Circle circle = new Circle(10, 20, "red", 15);
            shapes.Add(circle);

            var anotherCircle = circle.Clone();
            anotherCircle.ChangeColor("violet");
            
            shapes.Add(anotherCircle);

            var rectangle = new Rectangle(2, 4, "blue", 10, 20);
            shapes.Add(rectangle);
            var anotherRectangle = rectangle.Clone();
            anotherRectangle.ChangeColor("black");
            shapes.Add(anotherRectangle);
            shapes.Add(anotherRectangle.Clone());
            shapes.Last().ChangeColor("white");
            
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.Color);
            }
        }
    }
}