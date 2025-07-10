using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Alisson Cornell", "Polynomials");

        Console.WriteLine(assignment1.GetSummary());


        MathAssignment mathHomework = new MathAssignment("Brandon Allen", "Polynomials", "2A", "5-35");

        Console.WriteLine(mathHomework.GetSummary());
        Console.WriteLine(mathHomework.GetHomeworkList());
        

        WritingAssignment essay = new WritingAssignment("Crystal Waters", "Egyptian History", "Hatchepsut: The Female Pharaoh");

        Console.WriteLine(essay.GetSummary());
        Console.WriteLine(essay.GetWritingInformation());
    }
}