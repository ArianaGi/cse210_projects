public class EternalGoal : Goals
{
    public EternalGoal(string goalName, string description, int points) : base(goalName, description, points)
    {

    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override bool isComplete()
    {
        return false;
    }

    public override string GetDetails()
    {
        throw new NotImplementedException();
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{GoalName}|{Description}|{_points}";
    }
}