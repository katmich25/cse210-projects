using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What is the magic number? ");
        string answer = Console.ReadLine();
        int magicN = int.Parse(answer);

        int guess = 0;

        while (guess == magicN)
        {
            Console.Write("What is your guess? ");
            string answerGuess = Console.ReadLine();
            int guess = int.Parse(answerGuess);
            
            if (guess > magicN)
            {
                Console.Write("Lower");
            }
            else if (guess == magicN)
            {
                Console.Write("You guessed it!");
            }
            else
            {
                Console.Write("Higher");
            }
        }
        

        
    }
}