using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            private static int GetGuess()
            {
                int guess = 0;
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("You did not enter a valid guess.");
                    guess = GetGuess();
                }
                return guess;
            }
            // var generator = new RandomGenerator();
            // var randomNumber = generator.RandomNumber(1, 100);
            int allowedTries = 5;
            int numberOfTries = 0;
            Random random = new Random();
            int returnValue = random.Next(1, 100);


            // Console.Write("guess a nummber between 1 and 100 ");
            // string Guess = Console.ReadLine();

            while (true)
            {
                int guess = GetGuess();
                numberOfTries++;
                if (guess % returnValue == 0)
                {
                    Console.WriteLine("You Win");
                    break;
                }
                else
                {
                    Console.WriteLine("You lose");

                }
            }
        }
    }
