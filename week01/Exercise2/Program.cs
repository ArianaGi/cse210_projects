using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your grade percentage: ");
        string grade = Console.ReadLine();
        int gradepercentage = int.Parse(grade);
        char letter;

        if (gradepercentage >= 90)
        {
            letter = 'A';
        }
        else if (gradepercentage >= 80)
        {
            letter = 'B';
        }
        else if (gradepercentage >= 70)
        {
            letter = 'C';
        }
        else if (gradepercentage >= 60)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }

        Console.WriteLine($"You received a grade of {letter}.");

        if (gradepercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass the class. Try again next semester.");
        }
    }    }