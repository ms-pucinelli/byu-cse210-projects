using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);

        string gradeLetter = ""

        if (grade >= 90)
        {
            gradeLetter = "A";
        } 
        else if (grade >= 80)
        {
            gradeLetter = "B";
        }
        else if (grade >= 70)
        {
            gradeLetter = "C";
        } 
        else if (grade >= 60)
        {
            gradeLetter = "D";
        }
        else if (grade < 60)
        {
            gradeLetter = "F";
        }

        Console.WriteLine($"Your Grade is {gradeLetter}");
        
        if (grade >= 70)
        {
            Console.WriteLine("Pass");
        }
        else
        {
            Console.WriteLine("Fail");
        }
    }
}
