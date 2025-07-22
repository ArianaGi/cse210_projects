using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activitiesList = new List<Activity>();
        activitiesList.Add(new Running("Running", 30.0, 1.5, 5.6, 5.0 ));
        activitiesList.Add(new Cycling("Cycling", 45.5, 0.0, 7.8, 6.0));
        activitiesList.Add(new Swimming("Swimming", 40.0, 10.0, 6.0, 5.5));

        foreach (Activity activities in activitiesList)
        {
            Console.WriteLine(activities.GetSummary());
        }
    }
}