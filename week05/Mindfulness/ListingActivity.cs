using System.ComponentModel.Design.Serialization;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base ("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>();
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        DisplayStartingMessage();

        int duration = GetDuration() + 1;

        GetReady();
        GetRandomPrompt();

        ShowSpinner(5);
        Console.WriteLine("Start listing items:");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        List<string> responses = GetListFromUser(endTime);

        _count = responses.Count;

        Console.WriteLine($"You listed {_count} items.");

        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
    }

    public List<string> GetListFromUser(DateTime endTime)
    {
        List<string> responses = new List<string>();

        while (DateTime.Now < endTime)
        {
            string response = Console.ReadLine();    
            responses.Add(response);
        }

        return responses;
    }
}