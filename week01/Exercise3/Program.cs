using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

    
        int guess = 0;

        while (guess != number)
        {
            Console.Write("What is your guess? ");
            string answerGuess = Console.ReadLine();
            guess = int.Parse(answerGuess);
            //guess = int.Parse(Console.ReadLine()); (version corta)
            
            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }  
            else
            {
                Console.Write("You guessed it!");
            }
        }

        

        
    }
}