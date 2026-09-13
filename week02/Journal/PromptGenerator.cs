public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "How did I see the hand of the Lord in my life today?",
        "What song couldn't I get out of my head today?", 
        "What was the strongest emotion I felt today?", 
        "What was my favorite part of the day?", 
        "How was the weather today?"
     };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        
        return _prompts[index];
    }
}