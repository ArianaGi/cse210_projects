public class ChecklistGoal : Goals
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(int amountCompleted, int target, int bonus) : base("", "", 100)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;

    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;

            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Congratulations! You have completed your {GetGoalName} goal and earned a bonus.");
                _points += _bonus;
            }
        }

        else
        {
            Console.WriteLine("This goal has been already completed.");
        }
    }

    public override bool isComplete()
    {
        return _amountCompleted == _target;
    }

    public override string GetDetails()
    {
        return $"Checklist Goal: {GetGoalName} {GetDescription} Points: {_points}. Bonus: {_bonus}. {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"{GetGoalName} | {GetDescription} | {_amountCompleted}/{_target} | {_points} | {_bonus}";
    }

}