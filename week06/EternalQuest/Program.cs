using System;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
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
            string choice = Console.ReadLine();


            switch (choice)
            {
                case "1":
                    BreathingActivity startBreathingActivity = new BreathingActivity();
                    startBreathingActivity.Run();
                    break;

                case "2":
                    ReflectionActivity startReflectionActivity = new ReflectionActivity();
                    startReflectionActivity.Run();
                    break;

                case "3":
                    ListingActivity startListingActivity = new ListingActivity();
                    startListingActivity.Run();
                    break;

                case "4":
                    AffirmationsActivity startAffirmationsActivity = new AffirmationsActivity();
                    startAffirmationsActivity.Run();
                    break;

                case "5":
                    exit = true;
                    Console.WriteLine("You have exited the program successfully.");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please select an option from the menu.");
                    break;
        Goals 1Goal = new SimpleGoal("","");

        Console.Write("What is the name of your goal: ");
        string goalName = Console.ReadLine();

        Console.Write("Enter a brief description of your goal: ");
        string description = Console.ReadLine();

        //Console.Write("Enter the number of points this goal is worth: ");
        //int points = int.Parse(Console.ReadLine());

    }
}