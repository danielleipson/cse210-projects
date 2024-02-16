using System;
using System.Threading;

public abstract class Activity
{
    protected string Name { get; }
    protected string Description { get; }

    protected Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    
    public abstract void Start(int duration);

    protected virtual void DisplayStartingMessage(int duration)
    {
        Console.WriteLine($"Starting {Name} activity...");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Duration: {duration} seconds");
        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(3000); 
    }

    
    protected virtual void DisplayEndingMessage(int duration)
    {
        Console.WriteLine($"Good job! You have completed the {Name} activity.");
        Console.WriteLine($"Duration: {duration} seconds");
        Console.WriteLine("Pause for a moment before finishing...");
        Thread.Sleep(3000); 
    }
}
class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Choose an activity:");
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Listening");
        Console.WriteLine("3. Reflecting");
        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());

        
        switch (choice)
        {
            case 1:
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Start(10); 
                break;
            case 2:
                ListeningActivity listeningActivity = new ListeningActivity();
                listeningActivity.Start(15);
                break;
            case 3:
                 ReflectingActivity reflectingActivity = new
                 ReflectingActivity();
                reflectingActivity.Start(20); 
                break;
            default:
                Console.WriteLine("Invalid choice. Please choose again.");
                break;

        }
    }
}