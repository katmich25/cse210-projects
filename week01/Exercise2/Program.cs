using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradeText = Console.ReadLine();
        int gradePorcentage = int.Parse(gradeText);

        string letter = "";

        if (gradePorcentage >= 90)
        {
            letter = "A";
        }
        else if (gradePorcentage >= 80)
        {
            letter = "B";
        }
        else if (gradePorcentage >= 70)
        {
            letter = "C";
        }
        else if (gradePorcentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "E";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (gradePorcentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("You didn't pass the course. Good luck next time.");
        }



    }
}