using System;
// Creativity: I added a scripture library that allows the user to choose between three different scriptures 
// before starting the memorization process.
class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture(
            new Reference("Isaiah", 58, 13, 14),
            "Turn back, from doing your pleasure on my holy day, and call it a delight."
        );
        Scripture scripture2 = new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart, and he shall direct thy paths."
        );
        Scripture scripture3 = new Scripture(
            new Reference("Joshua", 24, 15),
            "Choose you this day whom ye will serve"
        );

        Console.WriteLine($"Choose a scripture:\n1. Isaiah 58:13-14\n2. Proverbs 3:5-6\n3. Joshua 24:15");
        Scripture selectedScripture;
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            selectedScripture = scripture;
        }

        else if (choice == 2)
        {
            selectedScripture = scripture2;
        }

        else
        {
            selectedScripture = scripture3;
        }

        Console.WriteLine(selectedScripture.GetDisplayText());
        Console.WriteLine("Press Enter to continue or type 'quit' to finish");
        string response = Console.ReadLine();
        if (response == "quit")
        {
            return;
        }

        while (!selectedScripture.IsCompletelyHidden())
        {
            selectedScripture.HideRandomWords(3);
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine("Press Enter to continue or type 'quit' to finish");
            string userResponse = Console.ReadLine();

            if (userResponse == "quit")
            {
                break;
            }
        }
    }
}