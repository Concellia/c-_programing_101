using System;

namespace TicTacConsoleGame
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            char[,] play = { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
            Console.WriteLine("Hello World");
            TicTac.startGame();

            Console.Read();
        }
    }
}
