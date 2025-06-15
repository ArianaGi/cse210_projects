using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Generate a random number between 1 and 100
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guessednumber;

        Console.WriteLine("I have selected a magic number between 1 and 100.");
        Console.WriteLine("What is your guess?: ");
        guessednumber = int.Parse(Console.ReadLine());

        while (guessednumber != number)
        {
            if (guessednumber < number)
            {
                Console.WriteLine("Go higher!");
            }
            else
            {
                Console.WriteLine("Go lower!");
            }

            Console.WriteLine("What is your guess?: ");
            guessednumber = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Congratulations! You guessed the magic number.");
    }
}