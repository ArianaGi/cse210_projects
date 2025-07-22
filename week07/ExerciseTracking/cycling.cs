public class Cycling : Activity
{
    public Cycling(string name, double minutes, double distance, double speed, double pace) : base("Cycling", minutes, distance, speed, pace)
    {

    }

    public void RunActivity()
    {
        GetSummary();
    }

}