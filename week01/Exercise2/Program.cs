using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);

        if (grade >= 90)
        {
            Console.WriteLine("Your grade is A. Congratulations!");
        } 
        else if (grade >= 80)
        {
            Console.WriteLine("Your grade is B.");
        }
        else if (grade >= 70)
        {
            Console.WriteLine(" Your grade is C.");
        } 
        else if (grade >= 60)
        {
            Console.WriteLine("Your grade is D. Good luck next time.");
        }
        else if (grade < 60)
        {
            Console.WriteLine("Your grade is F. Good luck next time.");
        }
        
    }
}
