using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1

{
    public class Car
    {
        string Model;
        public int Year;
        public double StartKm;
        public double EndKm;
        public double FuelConsumption;
        public double TravelTime;

        public Car(string model, int year, double start, double end, double fuel,
            double time)
        {
            Model = model;
            Year = year;
            StartKm = start;
            EndKm = end;
            FuelConsumption = fuel;
            TravelTime = time;
        }

        public double GetTripLength()
        {
            return EndKm - StartKm;
        }

        public double GetSpeed()
        {
            return GetTripLength() / TravelTime;
        }

        public double GetFuelEfficiency()
        {
            return GetTripLength() / (FuelConsumption / 100);
        }

        public string ClassifyCar()
        {
            int CarAge = DateTime.Now.Year - Year;
            if (CarAge < 1)
            {
                return "New car, enjoy it!";
            }
            if (CarAge >= 1 && CarAge < 3)
            {
                return "Semi-used car, how is it going?";
            }
            if (CarAge >= 3 && CarAge < 5)
            {
                return "Used car, it's probably a good time to start looking for a new one";
            }
            if (CarAge >= 5)
            {
                return "Old car, please change it";
            }
            return "Error";
        }
    }
}
