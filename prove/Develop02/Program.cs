using System;
using System.Collections.Generic;
using System.IO;


class Program
{
    private static List<string> entries = new List<string>();

    static void Main()
    {
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("Choose an Option:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display"); 
            Console.WriteLine("3. Open");
            Console.WriteLine("4. Save"); 
            Console.WriteLine("5. Close");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        WriteEntry();
                        break;
                    case 2:
                        DisplayEntries();
                        break;
                    case 3:
                        OpenFile();
                        break;
                    case 4:
                        SaveFile();
                        break;
                    case 5:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number");
            }
        }
    }

    static void WriteEntry()
    {
        string prompt = GetRandomPrompt();
        
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine("Write your entry:");
        string writtenText = Console.ReadLine();

        string entry = $"{DateTime.Now} - Prompt: {prompt}\n{writtenText}\n";

        entries.Add(entry);

        Console.WriteLine("Entry save to memory.\n");
    }

    static void DisplayEntries()
    {
        Console.WriteLine("All entries:\n");
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    static string OpenFile()
    {    
        Console.WriteLine("Enter the file name to open.");
        string fileName = Console.ReadLine();

        try
        {
            string[] fileEntries = File.ReadAllLines(fileName);

            Console.WriteLine($"Entries from '{fileName}':\n");
            foreach (var entry in fileEntries)
            {
                Console.WriteLine(entry);
            }
            
            return string.Join("\n", fileEntries);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"File '{fileName}' not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        return string.Empty;
    }

    static void SaveFile()
    {
        Console.WriteLine("Enter the file name to save:");
        string fileName = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine(entry);
                }
            }

            Console.WriteLine($"Entries save to '{fileName}'.\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving file: {ex.Message}");
        }
    }

    static string GetRandomPrompt()
    {
        List<string> prompts = new List<string>
        {
            "What is your favorite memory from today?",
            "Describe a challenge you overcame today?",
            "If you could travel anywhere, where would you go and why",
            "In what ways did the Lord bless your life today?",
            "What was one thing about yourself that you are proud of?",
            "What can you do to learn to love yourself?",
            "In what ways can you let your testimony teach others?",
            "How did your self talk from today make you feel? What can you do to turn it more positive?",
        };

        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }   
}