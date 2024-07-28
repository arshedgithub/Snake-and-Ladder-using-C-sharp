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
            { 41, 79 },  
            { 74, 88 },
            { 85, 95 },
            { 82, 100 }
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

            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("                           Snake And Ladder Game");
            Console.WriteLine("-------------------------------------------------------------------------------");

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
                        player_1_position = changePlayerPosition(player_1_position, player_1);
                        turnOfFirstPlayer = !turnOfFirstPlayer;
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
                        player_2_position = changePlayerPosition(player_2_position, player_2);
                        turnOfFirstPlayer = !turnOfFirstPlayer;
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

        // checking the position whether it was on a snake or ladder
        static int changePlayerPosition(int position, string player)
        {
            int new_position;

            if (ladders.ContainsKey(position))
            {
                new_position = ladders[position];
                Console.WriteLine(player + ", You reach a ladder. Your new position is " + new_position);
            }
            else if (snakes.ContainsKey(position))
            {
                new_position = snakes[position];
                Console.WriteLine(player + ", You stepped on a snake. Your new position is " + new_position);
            } else
            {
                new_position = position;
                Console.WriteLine(player + " Your new position is " + new_position);
            }

            if (new_position >= 100)
            {
                Console.WriteLine();
                Console.WriteLine(player + " Wins!");
            }

            return new_position;
        }
    }
}