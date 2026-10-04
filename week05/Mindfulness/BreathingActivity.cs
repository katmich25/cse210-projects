public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity",
    "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        int duration = GetDuration() + 1;

        GetReady();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime && (endTime - DateTime.Now).TotalSeconds >= 8)
        {
           Console.WriteLine("Breathe in...");
           ShowCountDown(4);
           Console.WriteLine("Breathe out...");
           ShowCountDown(4);  
           Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}