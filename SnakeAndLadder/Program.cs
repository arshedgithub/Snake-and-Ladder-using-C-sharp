using System;

namespace snakeAndLadderGame
{
    class Program
    {

        // ladders
        static Dictionary<int, int> ladders = new Dictionary<int, int>()
        {
            { 2, 23 },
            { 8, 34 },
            { 20, 77 },
            { 32, 68 },
            { 32, 68 },
            { 41, 79},
            { 74, 88},
            { 85, 95},
            { 82, 100}
        };

        // snakes
        static Dictionary<int, int> snakes = new Dictionary<int, int>()
        {
            { 29, 9 },
            { 38, 15 },
            { 47, 5 },
            { 53, 33 },
            { 62, 37 },
            { 86, 54},
            { 92, 70},
            { 97, 25}
        };




        static void Main(string[] args) 
        {
            int player_1_position = 0;
            int player_2_position = 0;

            Console.Write("Enter the player 1 name : ");
            string player_1 = Console.ReadLine();
            Console.Write("Enter the player 2 name : ");
            string player_2= Console.ReadLine();
            Console.WriteLine();

            bool turnOfFirstPlayer = true;

            while (player_1_position < 100 && player_2_position < 100)
            {
                if (turnOfFirstPlayer)
                {
                    // turn of first palyer
                    Console.Write($"{player_1}, Please roll the dice : ");
                    if (Console.ReadLine() == "r")
                    {
                        int diceValue = rollingDice();
                        Console.WriteLine("Dice Value : " + diceValue);
                        player_1_position += diceValue;
                        turnOfFirstPlayer = !turnOfFirstPlayer;
                        Console.WriteLine(player_1 + " Your new position is " + player_1_position);
                    } else
                    {
                        Console.WriteLine("Press r for roll dice!");
                    }
                } else
                // turn of second palyer

                {
                    Console.Write($"{player_2}, Please roll the dice : ");
                    if (Console.ReadLine() == "r")
                    {
                        int diceValue = rollingDice();
                        Console.WriteLine("Dice Value : " + diceValue);
                        player_2_position += diceValue;
                        turnOfFirstPlayer = !turnOfFirstPlayer;
                        Console.WriteLine(player_2 + " Your new position is " + player_2_position);
                    }
                    else
                    {
                        Console.WriteLine("Press r for roll dice!");
                    }
                }
            }
        }

        // function for generating number between 1 to 6 using Random class
        static int rollingDice()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }
    }
}