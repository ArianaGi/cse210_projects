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
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Affirmations Activity");
            Console.WriteLine("5. Exit");
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
            }
        }

    } 
}