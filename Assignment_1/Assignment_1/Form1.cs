using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class Form1 : Form

    {
        Car newCar;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get the input values from textboxes and check for validity
            string model = txtModel.Text;

            bool valid_year = int.TryParse(txtYear.Text, out _);
            if (!valid_year)
            {
                MessageBox.Show("Enter valid year");
                return;
            }
                         
            int year = int.Parse(txtYear.Text);

            bool valid_start = int.TryParse(txtStart.Text, out _);
            bool valid_end = int.TryParse(txtEnd.Text, out _);
            if (!valid_start | !valid_end)
            {
                MessageBox.Show("Invalid start or end km");
                return;
            }

            double start = double.Parse(txtStart.Text);
            double end = double.Parse(txtEnd.Text);

            bool valid_fuel = int.TryParse(txtFuel.Text, out _);
            if (!valid_fuel)
            {
                MessageBox.Show("Invalid fuel value");
                return;
            }
            double fuel = double.Parse(txtFuel.Text);

            bool valid_time = int.TryParse(txtTime.Text, out _);
            if (!valid_time)
            {
                MessageBox.Show("Invalid time input");
                return;
            }
            double time = double.Parse(txtTime.Text);


            // Create the Car object
            newCar = new Car(model, year, start, end, fuel, time);

            // Display a message to the user
            MessageBox.Show("The info about the car has been added!");
        }


        private void Distance_Click(object sender, EventArgs e)
        {
            double distance = newCar.GetTripLength();
            MessageBox.Show("The distance of the trip is " + distance + "km");
        }

        private void Speed_Click(object sender, EventArgs e)

        {
            double speed = newCar.GetSpeed();
            MessageBox.Show("The average speed during the trip is " + Math.Round(speed, 1) + "km/h");
        }

        private void Fuel_Click(object sender, EventArgs e)
        {
            double efficiency = newCar.GetFuelEfficiency();
            MessageBox.Show("The fuel efficiency is " + Math.Round(efficiency, 1) + " litres per 100km");
        }

        private void Class_Click(object sender, EventArgs e)
        {
            String message = newCar.ClassifyCar();
            MessageBox.Show(message);
        }
    }
}
