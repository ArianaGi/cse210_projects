public class ChecklistGoal : Goals
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string goalName, string description, int points, int target, int bonus, int amountCompleted = 0) : base(goalName, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;

    }

    public override int RecordEvent()
    {
        _amountCompleted++;

        if (_amountCompleted >= _target)
        {
            return _points + _bonus;
        }
        return _points;
    }

    public override bool isComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetails()
    {
        string checkbox = isComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {GetGoalName()} ({GetDescription()}) — {_amountCompleted}/{_target} completed";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GoalName}|{Description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
    }

}