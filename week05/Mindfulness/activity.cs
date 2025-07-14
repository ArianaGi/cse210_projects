using System.Security.Cryptography.X509Certificates;

class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        //_duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"You are about to start a {_name}.\n{_description}\n");

        //Console.WriteLine("Please enter the seconds you would like to spend in this activity: ");

        while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Console.Write("Please enter how many secondsyou would like to spend in this activity: ");
        }

        Console.WriteLine($"Get ready...");
        Thread.Sleep(2000);

    }

    public int GetDuration()
    {
        return _duration;
            
    }


    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + "...");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
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

        /*foreach (string s in spinner)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

        }*/

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


    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Congratulations! You have completed a {_name}. You spent {_duration} seconds on this activity. Keep up with the good work!");
    }

}