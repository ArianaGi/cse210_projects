using System.ComponentModel;

class BreathingActivity : Activity
{
    public BreathingActivity(string duration) : base("Breathing Activity", "\nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", duration)
    {
        _duration = duration;

    }

    public void Run()
    {
        DisplayStartingMessage();

        List<string> breathe = new List<string>();
        breathe.Add("Breathe in...");
        breathe.Add("Breathe out...");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string message = breathe[i];
            Console.Write(message);
            ShowCountDown();
            Thread.Sleep(5000);

            i++;

            if (i >= breathe.Count)
            {
                i = 0;
            }
        }

        Console.WriteLine("Well done!");

        DisplayEndingMessage();

    }
}