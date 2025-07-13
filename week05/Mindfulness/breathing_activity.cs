using System.ComponentModel;

class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        DisplayStartingMessage();
        
    }

    public void Run()
    {

    }
}