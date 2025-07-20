public class SimpleGoal : Goals
{
    private bool _isComplete;

    public SimpleGoal(string goalName, string description, int points) : base(goalName, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
       _isComplete = true;
       return _points;
    }
    public override bool isComplete()
    {
        return _isComplete;
    }

    public override string GetDetails()
    {
        return $"[{(_isComplete ? "X" : " ")}] {GoalName} ({Description})";
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{GoalName}|{Description}|{_points}|{_isComplete}";
    }

}