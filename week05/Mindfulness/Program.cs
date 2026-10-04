using System;
using System.Xml.Serialization;
class Program
//Creativity: Reflection questions are not repeated until all of them have been used at least once.
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity.");
            Console.WriteLine(" 2. Start reflecting activity.");
            Console.WriteLine(" 3. Start listing activity.");
            Console.WriteLine(" 4. Quit.");
            Console.WriteLine("Select a choice from the menu.");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                break;

                case 2:
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.Run();
                break;

                case 3:
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
                break;

                case 4:
                running = false;
                break;

            }
        }
    }
}