using System;
using Assignment_4.Classes;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Polygon square = new Square(5);
            Polygon hexagon = new Hexagon(3, 3);
            Console.WriteLine("For square with side length " + square.Length_per_side
                + " area equals " + square.GetArea() + " and perimeter equals " + square.GetPerimeter());
            Console.WriteLine("For hexagon with side length " + hexagon.Length_per_side
                + " area equals " + hexagon.GetArea() + " and perimeter equals " + hexagon.GetPerimeter());

        }
    }
}
