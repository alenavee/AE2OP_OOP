using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4.Classes
{
    class Hexagon: Polygon
    {
        public int Apothem
        { get; set; }

        public override int GetArea()
        {
            return GetPerimeter() * Apothem / 2;
        }

        public Hexagon(int length, int apothem, int sides = 6) : base(length, sides)
        {
            Apothem = apothem;
        }
    }
}
