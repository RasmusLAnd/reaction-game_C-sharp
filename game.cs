using System;
using System.Threading;

namespace reaction_game_C_sharp
{
    class Game
    {
        int startTick, reactionTime, time; //def af tidsvariabler
        public void Start()
        {
        Console.WriteLine("Are you ready to begin?.....(y/n)");
        char answer = Convert.ToChar(Console.ReadLine()); //laver string til char

            if (answer == 'y')
            {
                Console.WriteLine("push any key - when program says \"GO!!!!\"");
                Random rnd = new Random(); 
                time = rnd.Next(1000,5000); //random number between 1000 to 5000
                Thread.Sleep(time); //pausing the program in x miliseconds, x = time

                startTick = System.Environment.TickCount; // getting the timestamp
                               
                while(System.Environment.TickCount<(startTick + time)) //while waiting on "go" - number of ms...
                // determined above are not reached
                    {
                        if (Console.KeyAvailable) //if any key is pressed
                        {
                            Result(true); //sending true to "Result()" - meaning premature push
                            return;
                        }
                    }      

                Console.WriteLine("GO.......");
                while(true)
                        {
                            if (Console.KeyAvailable)
                            {
                                Result(false); //sending false to "Result()" - meaning "time" has passed
                                return;
                            }
                        }  

            }
            else
            {
                Console.Clear(); //if user said no "being ready"
                Start(); //re-run of start()
            }
        }

        public void Result(bool cheater)
        {
            if (cheater) //sending true from above
            {   Console.WriteLine("Cheater - shame on you");

            }
            else //sending false from above
            {
            reactionTime= System.Environment.TickCount-(startTick+time); 
            Console.WriteLine($"Your reaction time is {reactionTime} miliseconds");
            Console.ReadKey(); 
            }
        }
    }
}