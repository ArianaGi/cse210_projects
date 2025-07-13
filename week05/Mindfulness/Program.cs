using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("******** Activities Menu ********");
            Console.WriteLine("Please select the activity you would like to complete today:\n");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
        }
    }
}