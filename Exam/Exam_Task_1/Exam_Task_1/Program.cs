using System;

namespace Exam_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(2, 5);
            Point p2 = new Point(6, 4);
            Point p3 = new Point(2, 2);
            Point p4 = new Point(4, 3);

            double m1 = p1.CalculateSlope(p2);
            double m2 = p3.CalculateSlope(p4);

            if (m1 == m2)
            {
                Console.WriteLine("Parallel lines");
            }
            else
            {
                Console.WriteLine("Not Parallel");
            }

        }
    }
}
