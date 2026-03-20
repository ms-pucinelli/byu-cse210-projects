using System;

class Program
{
    static void Main(string[] args)
    {
        Random rng = new Random();
        int randomNumber = rng.Next(1, 101);
        int guess = 0;
        
        while (guess != randomNumber)
        {
            Console.Write("What is your guess? ");
            string guesString = Console.ReadLine();
            guess = int.Parse(guesString);

            if (guess < randomNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > randomNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

    }
}