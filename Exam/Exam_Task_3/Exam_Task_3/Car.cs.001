using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_Task_3
{
    class Car: IVehicle
    {
        public double Gasoline { get; set; }
        public Car()
        {
            Gasoline = 100;
        }

        public void Drive()
        {
            if (Gasoline > 0)
            {
                Console.WriteLine("Car can drive");
            }
            else
            {
                Console.WriteLine("Out of gasoline, need to refill");
            }
        }

        public bool Refuel(int amount)
        {
            if (amount < 0)
            {
                return false;
            }
            else
            {
                Gasoline += amount;
                return true;
            }
        }
    }
}
