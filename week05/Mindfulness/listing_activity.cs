using System.ComponentModel;

class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(int count, List<string> prompts, string name, string description, string duration) : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration)
    {
        _count = count;
        _prompts = prompts;
    }

    public List<string> GetListFromUser()
    {
        List<string> prompts = new List<string>();
        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are personal strengths of yours?");
        prompts.Add("Who are people that you have helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");

        return _prompts;
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        Console.WriteLine("Prompt: " + randomPrompt);
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Take a few seconds to reflect on this prompt");
        GetRandomPrompt();
        ShowCountDown();


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(30);

        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            Console.WriteLine("Keep adding to your list!");

            count++;
            

        }

        

        Console.WriteLine($"Time's up! You listed {_count} items.");

        DisplayEndingMessage();

    }

}