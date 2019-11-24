using System;

namespace reaction_game_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Reaction Game");
            Game startGame = new Game();//starter in instans af klassen startGame
            startGame.Start();//metoden start i klassen Game
        }
    }
}
