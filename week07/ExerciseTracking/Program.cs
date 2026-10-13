using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        DateTime date = new DateTime(2026, 10, 12);

        Running running = new Running(date, 30, 5);
        activities.Add(running);

        Cycling cycling = new Cycling(date, 30, 15);
        activities.Add(cycling);

        Swimming swimming = new Swimming(date, 30, 30);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}