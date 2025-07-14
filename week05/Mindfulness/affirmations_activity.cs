class AffirmationsActivity : Activity
{
    private List<string> _affirmations;

    public AffirmationsActivity() : base("Affirmations Activity", "This activity will help you center your thoughts by providing you with positive affirmations. These affirmations are designed to boost your confidence, promote self-compassion, and help you cultivate a calm and focused mindset. As you read and reflect on each affirmation, take a deep breath and allow the words to sink in.")
    {
        _affirmations = new List<string>
        {
            "I am grounded, calm, and centered.",
            "I am worthy of love, respect, and kindness.",
            "I trust myself and my journey.",
            "I am enough just as I am.",
            "I choose peace over worry.",
            "I release tension and welcome relaxation.",
            "I am growing stronger every day.",
            "I am present in this moment.",
            "My mind is clear, and my heart is open.",
            "I am filled with gratitude for this day."

        };
    }

    private string GetRandomAffirmation()
    {
        Random random = new Random();
        int index = random.Next(_affirmations.Count);
        string randomAffirmation = _affirmations[index];
        return _affirmations[index];
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Repeat the following affirmation as many times as needed. After each affirmation, take a couple of seconds to breathe, and then repeat the affirmation again until you reach the time limit.");

        string affirmation = GetRandomAffirmation();
        Console.WriteLine($"{_affirmations}");
        
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"\n{affirmation}\n");
            Console.WriteLine("Repeat the affirmation.");
            Thread.Sleep(5000);
            Console.WriteLine("Now pause, and take a deep breath.");
            ShowCountDown(5);
            Console.WriteLine("Repeat the affirmation one more time."); 

        }

        Console.WriteLine("Well done!");

        DisplayEndingMessage();

    }
}