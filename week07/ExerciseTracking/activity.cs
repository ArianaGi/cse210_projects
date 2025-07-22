using System.Runtime.InteropServices.Marshalling;

public abstract class Activity
{
    private string _name;
    private double _minutes;
    private double _distance;
    private double _speed;
    private double _pace;
    private List<DateTime> _dateTracking;

    public Activity(string name, double minutes, double distance, double speed, double pace)
    {
        _name = name;
        _minutes = minutes;
        _distance = distance;
        _speed = 60 / _pace;
        _pace = 60 / _speed;
        _dateTracking = new List<DateTime>();
    }

    public string GetName()
    {
        return _name;
    }

    public double GetLength()
    {
        return _minutes;
    }

    public virtual double GetDistance()
    {
        return _distance;
    }

    public virtual double GetSpeed()
    {
        return _speed;
    }
    public virtual double GetPace()
    {
        return _pace;
    }

    public string GetSummary()
    {
        return $"Date: {DateTime.Now} {_name}:\n{_minutes} minutes\nDistance: {_distance} miles\nSpeed: {_speed} mph\nPace: {_pace} min/km";
    }


}