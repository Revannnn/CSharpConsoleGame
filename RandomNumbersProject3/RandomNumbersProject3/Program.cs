using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbersProject3
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();
            GreetUser();
            while (true)
            {



                //int correctNumber = 7;
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                int guess = 0;
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter an actual number!");
                        Console.ResetColor();

                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong Number, Please try again");
                        Console.ResetColor();

                    }
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You are CORRECT!!!");
                Console.ResetColor();

                Console.WriteLine("Play Again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                   
                }
                else
                {
                    return;
                }

            }

             void GetAppInfo()
            {
                // Set app vars
                string appName = "Number Guesser";
                string appVersion = "1.0.0";
                string appAuthor = "Ravan Mahmudlu";

                // Change Text Color
                Console.ForegroundColor = ConsoleColor.Green;

                // Write out App Info
                Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

                // Reset Text Color
                Console.ResetColor();
            }

             void GreetUser()
            {
                Console.WriteLine("What is your Name?");
                string inputName = Console.ReadLine();

                Console.WriteLine("Hello {0}, let`s play a game... ", inputName);

            }

        }
    }
}
