using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Office Manager";
        job1._company = "ERA Realty";
        job1._startYear = 2012;
        job1._endYear = 2018;

        Job job2 = new Job();
        job2._jobTitle = "Payment Specialist";
        job2._company = "State of Ohio";
        job2._startYear = 2018;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Makel Bronneman";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}