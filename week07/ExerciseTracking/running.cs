public class Running : Activity
{

    public Running(string name, double minutes, double distance, double speed, double pace) : base("Running", minutes, distance, speed, pace)
    {

    }

    public override double GetDistance()
    {
        return 0;
    }

    public void RunActivity()
    {
        GetSummary();
    }

   
}