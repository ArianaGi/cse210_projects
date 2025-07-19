public class GoalManager
{
    private int _score;
    private DateTime _lastRecordedDate;
    private int _currentStreak;
    private int _longestStreak;

    private List<Goals> _goals = new List<Goals>();

    public GoalManager(int score)
    {
    
        foreach (Goals goals in goaltypes)
        {
            Console.WriteLine(goals.GetStringRepresentation());
            Console.WriteLine(goals.GetStringRepresentation());
            Console.WriteLine(goals.GetStringRepresentation());
        }

        _score = score;

        _lastRecordedDate = DateTime.MinValue;
        _currentStreak = 0;
        _longestStreak = 0;

    }

    public void start()
    {

    }

    public void DisplayPlayerInfo()
    {

    }

    public void ListGoalNames()
    {

    }

    public void ListGoalDetails()
    {

    }

    public void CreateGoal()
    {
        Console.WriteLine("Select the type of goal you would like to create:");

        Console.WriteLine("a. Simple Goal");
        Console.WriteLine("b. Eternal Goal");
        Console.WriteLine("c. Checklist Goal");

        string choice = Console.ReadLine();

        switch (choice)
            {
                case "a.":
                    Console.Write("You have chosen to create a Simple Goal.");
                    Console.Write("What is the name of your goal: ");
                    string goalName = Console.ReadLine();
                    Console.Write("Please provide a brief description of your goal:");
                    string description = Console.ReadLine();
                    Console.Write("Enter the number of points this goal is worth: ");
                    int points = int.Parse(Console.ReadLine());
                    SimpleGoal createSimpleGoal = new SimpleGoal(goalName, description);
                    _goals.Add(createSimpleGoal);
                    createSimpleGoal.GetDetails();
                    break;

                case "b.":
                    EternalGoal createEternalGoal = new EternalGoal();
                    Console.Write("You have chosen to create an Eternal Goal.");
                    Console.Write("What is the name of your goal: ");
                    goalName = Console.ReadLine();
                    Console.Write("Please provide a brief description of your goal:");
                    description = Console.ReadLine();
                    Console.Write("Enter the number of points this goal is worth: ");
                    points = int.Parse(Console.ReadLine());
                    _goals.Add(createEternalGoal);
                    createEternalGoal.GetDetails();
                    break;

                case "3":
                    Console.Write("You have chosen to create a Checklist Goal.");
                    Console.Write("What is the name of your goal: ");
                    goalName = Console.ReadLine();
                    Console.Write("Please provide a brief description of your goal:");
                    description = Console.ReadLine();
                    Console.Write("Enter the number of points this goal is worth: ");
                    points = int.Parse(Console.ReadLine());
                    Console.Write("How many times does this goal need to be accomplished for a bonus?");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus you will receive for accomplishing this goal for that number of times?");
                    int bonus = int.Parse(Console.ReadLine());
                    ChecklistGoal createChecklistGoal = new ChecklistGoal(0, target, bonus);
                    _goals.Add(createChecklistGoal);
                    createChecklistGoal.GetDetails();
                    break;



    }

    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {

    }

    public void RecordProgress()
    {
        DateTime Today = DateTime.Today;

        if (_lastRecordedDate == Today.AddDays(-1))
        {
            _currentStreak++;
        }

        else if (_lastRecordedDate == Today)
        {
            Console.WriteLine("You already recorded progress today!");
            return;
        }

        else
        {
            _currentStreak = 1;
        }

        _lastRecordedDate = Today;

        if (_currentStreak > _longestStreak)
        {
            _longestStreak = _currentStreak;
        }

        Console.WriteLine("Progress recorded for today!");
        Console.WriteLine($"Current streak: {_currentStreak} day(s)");
        Console.WriteLine($"Longest streak: {_longestStreak} days()");
    }



}