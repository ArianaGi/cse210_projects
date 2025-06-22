public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What was the best part of your day?",
        "What did you learn today?",
        "What are you grateful for?",
        "Describe a challenge you faced today and how you overcame it.",
        "What is something that made you smile today?",
        "What is a goal you want to achieve this week?",
        "Reflect on a recent accomplishment.",
        "What is something new you want to try?",
        "Write about a person who inspires you.",
        "What is a lesson you learned from a mistake?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}