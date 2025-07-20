using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private int _score;
    private DateTime _lastRecordedDate;
    private int _currentStreak;
    private int _longestStreak;
    private List<Goals> _goals = new List<Goals>();
   

    public GoalManager(int score)
    {
        _score = score;
        _lastRecordedDate = DateTime.MinValue;
        _currentStreak = 0;
        _longestStreak = 0;

    }

    public void start()
    {
        string input = "";

        while (input != "6")
        {
            Console.WriteLine("******** Activities Menu ********");
            Console.WriteLine("Please select the activity you would like to complete today:\n");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Please enter the number of your choice: ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoals();
                    DisplayPlayerInfo();
                    break;
                case "3":
                    Console.Write("Enter filename to save goals: ");
                    string saveFile = Console.ReadLine();
                    SaveGoals(saveFile);
                    break;
                case "4":
                    Console.Write("Enter filename to load goals: ");
                    string loadFile = Console.ReadLine();
                    LoadGoals(loadFile);
                    break;
                case "5":
                    RecordEvent();
                    RecordProgress();
                    break;
                case "6":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your current score is {_score}.");
    }

    public void ListGoals()
    {
        int index = 1;
        foreach (Goals goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetDetails()}");
            index++;
        }
    }

    public void ListGoalNames()
    {
        foreach (Goals goal in _goals)
        {
            Console.WriteLine(goal.GetGoalName());
        }
    }

    public void ListGoalDetails()
    {
        foreach (Goals goal in _goals)
        {
            Console.WriteLine($"{goal.GetDetails}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Select the type of goal you would like to create:");

        Console.WriteLine("a. Simple Goal");
        Console.WriteLine("b. Eternal Goal");
        Console.WriteLine("c. Checklist Goal");

        string choice = Console.ReadLine();

        Console.Write("\nWhat is the name of your goal: ");
        string goalName = Console.ReadLine();
        Console.Write("Please provide a brief description of your goal: ");
        string description = Console.ReadLine();
        Console.Write("Enter the number of points this goal is worth: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "a":
                SimpleGoal simple = new SimpleGoal(goalName, description, points);
                _goals.Add(simple);
                break;
            case "b":
                EternalGoal eternal = new EternalGoal(goalName, description, points);
                _goals.Add(eternal);
                break;
            case "c":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus you will receive for accomplishing this goal that number of times? ");
                int bonus = int.Parse(Console.ReadLine());
                ChecklistGoal checklist = new ChecklistGoal(goalName, description, points, target, bonus);
                _goals.Add(checklist);
                break;
        }
            
        }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available to record.");
            return;
         }

        Console.WriteLine("What goal did you complete?");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetGoalName()}");
        }

        Console.Write("Enter the number of the goal you completed: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int goalNumber) && goalNumber >= 1 && goalNumber <= _goals.Count)
        {
            Goals selectedGoal = _goals[goalNumber - 1];
            int pointsEarned = selectedGoal.RecordEvent();
            _score += pointsEarned;
            Console.WriteLine($"Your event has been recorded successfully! You earned {pointsEarned} points.");
        }
        else
        {
            Console.WriteLine("Invalid selection. Please try again.");
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);

            foreach (Goals goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals(string filepath)
    {
        if (File.Exists(filepath))
        {
            string[] lines = File.ReadAllLines(filepath);
            _score = int.Parse(lines[0]);
            _goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                Goals goal = Goals.CreateGoalFromString(lines[i]);
                _goals.Add(goal);
            }

            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
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