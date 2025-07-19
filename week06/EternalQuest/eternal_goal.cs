public class EternalGoal : Goals
{
    public EternalGoal() : base("", "", 200)
    {

    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Great job! You earned {_points} points for completing your Eternal Goal. Earn more points as you keep working on this eternal goal!");
    }

    public override bool isComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"{GetGoalName} | {GetDescription} | Points: {_points}";
    }
}