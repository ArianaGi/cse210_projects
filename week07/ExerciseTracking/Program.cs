using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activitiesList = new List<Activity>();
        activitiesList.Add(new Running(30.0, 3.0));
        activitiesList.Add(new Cycling(45.5, 15.0));
        activitiesList.Add(new Swimming(40.0, 20));

        foreach (Activity activities in activitiesList)
        {
            Console.WriteLine(activities.GetSummary());
            Console.WriteLine();
        }
    }
}