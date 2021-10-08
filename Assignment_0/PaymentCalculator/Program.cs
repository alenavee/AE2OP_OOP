using System;

namespace PaymentCalculator
{
    class Program
    {

        static double CalculatePrice(int price, int quantity, int discount, int tax)
        {
            double totalPrice = price * quantity * (1 - discount * 0.01) * (1 + tax * 0.01);
            return totalPrice;
        }


        static void Main(string[] args)
        {
            double totalPrice = CalculatePrice(7, 5, 4, 21);
            Console.WriteLine("The total price is {0}", totalPrice);
        }
    }

}
