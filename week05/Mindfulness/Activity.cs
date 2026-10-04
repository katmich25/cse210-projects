public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine(_description);
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        ShowSpinner(5);
        Console.WriteLine();
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("_");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationString.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
        }
    }

    public void GetReady()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }
}