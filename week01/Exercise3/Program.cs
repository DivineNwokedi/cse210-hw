using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;
        while (playAgain)
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int attempts = 0;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());attempts++;

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it!, it took you {attempts} attempts." );
                };
            }
            Console.Write("Would you like to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            playAgain = response == "yes";    
        }
    }
}