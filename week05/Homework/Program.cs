using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Alisson Cornell", "Polynomials");

        Console.WriteLine(assignment1.GetSummary());
    }
}