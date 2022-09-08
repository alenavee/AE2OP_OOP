using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_Task_1
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double CalculateSlope(Point p2)
        {
            return (p2.Y - Y) / (p2.X - X);
        }
    }
}
