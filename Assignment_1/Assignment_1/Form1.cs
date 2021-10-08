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


            // Get the input values from textboxes
            string model = txtModel.Text;
            int year = int.Parse(txtYear.Text);
            double start = double.Parse(txtStart.Text);
            double end = double.Parse(txtEnd.Text);
            double fuel = double.Parse(txtFuel.Text);
            double time = double.Parse(txtTime.Text);


            // Create the Car object
            newCar = new Car(model, year, start, end, fuel, time);

            // Display a message to the user
            MessageBox.Show("The info about the car has been added!");

        }


        private void distance_Click(object sender, EventArgs e)
        {
            double distance = newCar.GetTripLength(newCar.StartKm, newCar.EndKm);
            MessageBox.Show("The distance of the trip is " + distance + "km");
        }

        private void speed_Click(object sender, EventArgs e)

        {
            double distance = newCar.GetTripLength(newCar.StartKm, newCar.EndKm);
            double speed = newCar.GetSpeed(distance, newCar.TravelTime);
            MessageBox.Show("The average speed during the trip is " + Math.Round(speed, 1) + "km/h");

        }

        private void fuel_Click(object sender, EventArgs e)
        {
            double distance = newCar.GetTripLength(newCar.StartKm, newCar.EndKm);
            double efficiency = newCar.GetFuelEfficiency(newCar.FuelConsumption, distance);
            MessageBox.Show("The fuel efficiency is " + Math.Round(efficiency, 1) + " litres per 100km");
        }

        private void class_Click(object sender, EventArgs e)
        {
            String message = newCar.ClassifyCar(newCar.Year);
            MessageBox.Show(message);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
