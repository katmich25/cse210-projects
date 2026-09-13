using System;
using System.Diagnostics;
//Exceeding Requirements: I added a feature that tells the user how many journal entries they currently have when they choose Display.

class Program
{
    static void Main(string[] args)
    {
            Journal journal = new Journal();
            PromptGenerator prompts = new PromptGenerator();

            Console.WriteLine("Welcome to your Journal!");
            
            bool running = true;
            while (running)
            {
                Console.WriteLine("Please select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.WriteLine("What would you like to do? ");
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    //#1 Write
                    case 1:
                    {
                        string prompt = prompts.GetRandomPrompt();
                        Console.WriteLine(prompt);
                        string response = Console.ReadLine();
                        string date = DateTime.Now.ToShortDateString();

                        Entry newEntry = new Entry();
                        newEntry._date = date;
                        newEntry._promptText = prompt;
                        newEntry._entryText = response;

                        journal.AddEntry(newEntry);

                        break;
                    }
                    
                    //#2 Display
                    case 2:
                    {
                        Console.WriteLine($"You have {journal._entries.Count} entries.");
                        journal.DisplayAll();
                        break;
                    }

                    //#3 Load
                    case 3:
                    {
                        Console.WriteLine("What is the file name? ");
                        string fileName = Console.ReadLine();
                        journal.LoadFromFile(fileName);
                        break;
                    }

                    //#4 Save
                    case 4:
                    {
                        Console.WriteLine("What is the file? ");
                        string saveFile = Console.ReadLine();
                        journal.SaveToFile(saveFile);

                        break;
                    }

                    //#5 Quit
                    case 5:
                    {
                        running = false;

                        break;
                    }
                }

            }
    }
}

           