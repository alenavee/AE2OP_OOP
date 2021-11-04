using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4.Classes
{
    class Square: Polygon
    {
        public Square(int length, int sides = 4) : base(length, sides)
        {
        }

        public override int GetArea()
        {
            return Length_per_side * Length_per_side;
        }
    }
}
