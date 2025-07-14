using System.ComponentModel;

class BreathingActivity : Activity
{
    private List<string> _breathe = new List<string> { "Breathe in...", "Breathe out..." };
    public BreathingActivity() : base("Breathing Activity", "\nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        int breatheIndex = 0;

        while (DateTime.Now < endTime)
        {
            string breathe = _breathe[breatheIndex];
            Console.Write(breathe + " ");

            for (int countdown = 5; countdown >= 1; countdown--)
            {
                Console.Write($"{countdown}\n");
                Thread.Sleep(1000);
            }

            breatheIndex++;

            if (breatheIndex >= _breathe.Count)
            {
                breatheIndex = 0;
            }
        }

        Console.WriteLine("Well done!");

        DisplayEndingMessage();

    }
}