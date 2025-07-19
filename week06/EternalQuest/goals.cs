public abstract class Goals
{
    private string _goalName;
    protected int _points;
    private string _description;
    private bool _isComplete;

    public Goals(string goalName, string description, int points)
    {
        _goalName = goalName;
        _points = points;
        _description = description;
        _isComplete = false;
    }

    public abstract void RecordEvent();

    public abstract bool isComplete();

    public string GetGoalName()
    {
        return _goalName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string setCheckBox()
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
    }

    public virtual string GetDetails()
    {
        return $"Goal details: \n{setCheckBox} {_goalName} {_points}";
    }

    public abstract string GetStringRepresentation();
}