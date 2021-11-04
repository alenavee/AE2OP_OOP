using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4.Classes
{
    public abstract class Polygon
    {   
        public int Num_of_sides
        { get; set; }

        public int Length_per_side
        { get; set; }

        public virtual int GetPerimeter()
        {
            return Num_of_sides * Length_per_side;
        }

        protected Polygon(int length, int sides)
        {
            Length_per_side = length;
            Num_of_sides = sides;            
        }

        public abstract int GetArea();
    }
}
