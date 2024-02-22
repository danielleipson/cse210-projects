using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var activities = new List<Activity>
        {
            new Running(new DateTime(2024, 2, 19), 30, 3.0),
            new Cycling(new DateTime(2024, 2, 20), 45, 15.0),
            new Swimming(new DateTime(2024, 2, 21), 60, 20),
            new Hiking(new DateTime(2024, 2, 22), 90, 5.0, 1000) 
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
