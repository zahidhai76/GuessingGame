using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Points newGame = new Points();
            Console.Write("What is your name? ");
            newGame.Player = Console.ReadLine();
            Program.Question1(newGame);
            Program.Question2(newGame);
            Program.Question3(newGame);
            if((newGame.Ctr / 3 ) * 100 == 100)
            {
                Console.WriteLine("Well done " + newGame.Player + ", you scored 100%!");
            }
            else if ((newGame.Ctr / 3) * 100 > 60 && (newGame.Ctr / 3) * 100 < 80)
            {
                Console.WriteLine("Good job " + newGame.Player + ", you got " + newGame.Ctr + " correct.");
            }
            else if ((newGame.Ctr / 3) * 100 < 60)
            {
                Console.WriteLine("You only got " + newGame.Ctr + " correct.");
            }
        }

        public static void Question1(Points newGame)
        {
            bool finished = false;
            while (!finished)
            {
                try
                {
                    string guess;
                    int counter = 0;
                    do
                    {
                        Console.Write("What is the capital of England? ");
                        guess = (Console.ReadLine()).ToLower();
                        if (guess == "london")
                        {
                            newGame.AddPoint();
                        }
                        else
                        {
                            counter++;
                            if (counter < 3)
                            {
                                Console.Write("Try again. ");
                            }
                        }
                    }
                    while (guess != "london" && counter != 3);
                    if(counter == 3)
                    {
                        Console.WriteLine("You've failed this question.");
                    }
                    finished = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public static void Question2(Points newGame)
        {
            bool finished = false;
            while (!finished)
            {
                try
                {
                    string guess;
                    int counter = 0;
                    do
                    {
                        Console.Write("What is the capital of Wales? ");
                        guess = (Console.ReadLine()).ToLower();
                        if (guess == "cardiff")
                        {
                            newGame.AddPoint();
                        }
                        else
                        {
                            counter++;
                            if (counter < 3)
                            {
                                Console.Write("Try again. ");
                            }
                        }
                    }
                    while (guess != "cardiff" && counter != 3);
                    if (counter == 3)
                    {
                        Console.WriteLine("You've failed this question.");
                    }
                    finished = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public static void Question3(Points newGame)
        {
            bool finished = false;
            while (!finished)
            {
                try
                {
                    string guess;
                    int counter = 0;
                    do
                    {
                        Console.Write("What is the capital of France? ");
                        guess = (Console.ReadLine()).ToLower();
                        if (guess == "paris")
                        {
                            newGame.AddPoint();
                        }
                        else
                        {
                            counter++;
                            if (counter < 3)
                            {
                                Console.Write("Try again. ");
                            }
                        }
                    }
                    while (guess != "paris" && counter != 3);
                    if (counter == 3)
                    {
                        Console.WriteLine("You've failed this question.");
                    }
                    finished = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }


    }

    public class Points
    {
        private int ctr;
        private string player;
        public int Ctr
        {
            get { return ctr; }
            set { ctr = value; }
        }

        public string Player
        {
            get { return player; }
            set { player = value; }
        }

        public void AddPoint()
        {
            ctr++;
        }

    }


}
