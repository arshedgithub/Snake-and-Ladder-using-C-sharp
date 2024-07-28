using System;

namespace snakeAndLadderGame
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Hello World!");

            Random rad = new Random();
            int randomNum = rad.Next(1,7);
            Console.WriteLine(randomNum);
        }
    }
}