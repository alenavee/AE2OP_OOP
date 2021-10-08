using System;

namespace DiceGame
{

    class DiceGame
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Boolean winner = false;

            Console.WriteLine("Press any key to roll a dice");
            Console.ReadKey();

            while (!winner)
            {
                {
                    int yourDice = rnd.Next(1, 7);
                    int compDice = rnd.Next(1, 7);
                    Console.WriteLine("You rolled {0}, computer rolled {1}", yourDice, compDice);
                    if (yourDice > compDice)
                    {
                        Console.WriteLine("You win!");
                        winner = true;

                    }
                    else if (compDice > yourDice)
                    {
                        Console.WriteLine("Computer wins!");
                        winner = true;

                    }
                }
            }
        }
    }
}
