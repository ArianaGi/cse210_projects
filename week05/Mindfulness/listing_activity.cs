using System.ComponentModel;

class ListingActivity : Activity
{

    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        return _prompts[index];
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine("List as many responses to the prompt as they come to your mind:");
        Console.WriteLine($"{prompt}");

        Console.WriteLine("Start listing in:");
        ShowCountDown(5);

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int count = 0;

        Console.WriteLine("You can start listing your items now! Please press enter after each item.");

        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            Console.WriteLine("Keep adding to your list!");

            count++;
        }

        Console.WriteLine($"Time's up! You listed {count} items.");

        DisplayEndingMessage();

    }

}