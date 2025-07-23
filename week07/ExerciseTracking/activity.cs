using System.Runtime.InteropServices.Marshalling;

public abstract class Activity
{
    private string _name;
    private double _minutes;
    private double _distance;
    private double _speed;
    private double _pace;
    private List<DateTime> _dateTracking;

    public Activity(string name, double minutes, double distance)
    {
        _name = name;
        _minutes = minutes;
        _distance = distance;
        _speed = (minutes > 0) ? (distance / minutes) *60 : 0;
        _pace = (distance > 0) ? minutes / distance : double.PositiveInfinity;
        _dateTracking = new List<DateTime> {DateTime.Now};
    }

    public string GetName() => _name;

    public double GetLength() => _minutes;

    public virtual double GetDistance() => _distance;

    public virtual double GetSpeed() => _speed;
    public virtual double GetPace() => _pace;

    public string GetSummary()
    {
        return $"Date: {DateTime.Now} {_name}:\n{_minutes} minutes\nDistance: {_distance} miles\nSpeed: {_speed:F2} mph\nPace: {_pace:F2} min/mile";
    }

}