using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal(); // <== Moved here so it's not re-created every time
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("======== Main Menu ========");
            Console.WriteLine("--What would you like to do?--");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save entry");
            Console.WriteLine("4. Load entry");
            Console.WriteLine("5. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.AddNewEntry();
                    break;

                case "2":
                    journal.DisplayEntries();
                    break;

                case "3":
                    Console.Write("Enter filename to save to: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "4":
                    Console.Write("Enter filename to load from: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case "5":
                    exit = true;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }

            Console.WriteLine(); // spacing
        }
    }
}