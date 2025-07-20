public abstract class Goals
{
    private string _goalName;
    protected int _points;
    private string _description;
    //private bool _isComplete;

    public Goals(string goalName, string description, int points)
    {
        _goalName = goalName;
        _points = points;
        _description = description;
    }
    
     public string GoalName => _goalName;
     public string Description => _description;
     public int Points => _points;


    public static Goals CreateGoalFromString(string line)
    {
        string[] parts = line.Split('|');
        string type = parts[0];

        switch (type)
        {
            case "SimpleGoal":
                return new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));

            case "EternalGoal":
                return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));

            case "ChecklistGoal":
                return new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));

            default:
                throw new Exception("Unknown goal type.");
        }
    }

    public virtual int RecordEvent()
    {
        return 0;
    }

    public abstract bool isComplete();

    public string GetGoalName()
    {
        return _goalName;
    }

    public string GetDescription()
    {
        return _description;
    }

    /*public string setCheckBox()
    {
        string complete = "[✔]";
        string incomplete = "[ ]";

        if (_isComplete == true)
        {
            return complete;
        }
        else
        {
            return incomplete; 
        }
    }*/

    public abstract string GetDetails();

    public abstract string GetStringRepresentation();
}