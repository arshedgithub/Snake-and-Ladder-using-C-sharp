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
            Console.WriteLine("Hello World!");
             
            
        }

        // function for generating number between 1 to 6 using Random class
        static int rollingDice()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }
    }
}