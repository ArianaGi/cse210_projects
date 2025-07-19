public class SimpleGoal : Goals
{
    private bool _isComplete;

    public SimpleGoal(string goalName, string description) : base(goalName, description, 50)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Congratulations! You earned {_points} points for completing this goal.");
        }
        else
        {
            Console.WriteLine("This goal is already complete.");
        }
        
    }

    public override bool isComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"Simple Goal: {setCheckBox} | {GetGoalName()} | {GetDescription()} | Points: {_points}";
    }

}