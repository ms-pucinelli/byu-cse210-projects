using System;

class Program
{
    static void Main(string[] args)
    {
        int radomNumber = 1;
        int guess = 0;
        
        Console.Write("What is the magic number? ");
        string givenNumber = Console.ReadLine();
        radomNumber = int.Parse(givenNumber);
        
        while (guess != radomNumber)
        {
            Console.Write("What is your guess? ");
            string guesString = Console.ReadLine();
            guess = int.Parse(guesString);

            if (guess < radomNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > radomNumber)
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