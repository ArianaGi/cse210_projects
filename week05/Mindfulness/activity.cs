class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"You are about to start a {_name}.\n{_description}\n");
        Console.WriteLine("How many seconds woud you like to spend in this activity?");
        Console.ReadLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Congratulations! You have completed a {_name}. You spent {_duration} on this activity. Keep up with the good work!");
    }

    public void ShowSpinner()
    {
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinner[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= spinner.Count)
            {
                i = 0;
            }
        }

    }

    public void ShowCountDown()
    {
        Console.WriteLine("Please enter the seconds you would like to spend in this activity: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int seconds) && seconds > 0)
        {
            Console.WriteLine($"You are about to start a {_name}");

            for (int i = seconds; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);

            }

            Console.WriteLine("Done!");
        }
    }

}