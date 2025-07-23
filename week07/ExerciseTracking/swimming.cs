public class Swimming : Activity
{
    private double _Distance;
    private double _Speed;
    private double _Pace;

    public Swimming(double minutes, int laps) : base("Swimming", minutes, (laps * 50) / 1000.0 * 0.62)
    {
        _Distance = (laps * 50) / 1000 * 0.62;
        _Speed = (minutes > 0) ? (_Distance / minutes) * 60 : 0;
        _Pace = (_Distance > 0) ? minutes / _Distance : double.PositiveInfinity;


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
}