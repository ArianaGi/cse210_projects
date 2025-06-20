using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Embedded Systems Engineer";
        job1._company = "(Tech Innovations Inc.)";
        job1._startYear = 2020;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "(Global Tech Solutions)";
        job2._startYear = 2018;
        job2._endYear = 2020;

        Resume resume = new Resume();
        resume._name = "Alice Johnson";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayResume();        


    }
}