using System;

namespace Exam_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Gasoline = 0;
            Console.WriteLine(car.Gasoline);

            Console.WriteLine(car.Refuel(-100));
            Console.WriteLine(car.Refuel(50));
            Console.WriteLine(car.Gasoline);
            car.Drive();
            
        }
    }
}
