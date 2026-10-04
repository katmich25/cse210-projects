public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private List<string> _availableQuestions;

    public ReflectionActivity() : base ("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life")
    {
        _prompts = new List<string>();
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions = new List<string>();
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        _availableQuestions = new List<string>(_questions);
    }

    public void Run()
    {
        DisplayStartingMessage();

        int duration = GetDuration() + 1;

        GetReady();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        DisplayPrompt();
        DisplayQuestions(endTime);

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        if (_availableQuestions.Count == 0)
        {
            _availableQuestions = new List<string>(_questions);
        }

        Random random = new Random();
        int index = random.Next(_availableQuestions.Count);
        string question = _availableQuestions[index];
        _availableQuestions.RemoveAt(index);

        return question;
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
    }

    public void DisplayQuestions(DateTime endTime)
    {
        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            Console.WriteLine(question);

            TimeSpan remaining = endTime - DateTime.Now;
            int spinnerTime = Math.Max(1, Math.Min(10, (int)remaining.TotalSeconds));
            ShowSpinner(spinnerTime);
        }
    }
}