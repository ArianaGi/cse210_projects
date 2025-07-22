public class Swimming : Activity
{
    private double _Distance;
    private double _Speed;
    private double _Pace;

    public Swimming(string name, double minutes, double distance, double speed, double pace) : base("Swimming", minutes, distance, speed, pace)
    {
        _Distance = distance * 50 / 1000 * 0.62;
        _Speed = (distance / minutes) * 60;
        _Pace = minutes / distance;


    }

    public override double GetDistance()
    {
        return _Distance;
    }

    public override double GetSpeed()
    {
        return _Speed;
    }

    public override double GetPace()
    {
        return _Pace;
    }

    public void RunActivity()
    {
        GetSummary();

    }
}