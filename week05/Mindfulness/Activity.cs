using System;
using System.Threading;

public abstract class Activity
{
    public string Name;
    public string Description;
    protected int Duration;

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {Name}!");
        Console.WriteLine(Description);
        Console.Write("\nEnter the duration of the activity in seconds: ");
        
        int duration;
        while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
        {
            Console.Write("Please enter a valid positive number: ");
        }
        Duration = duration; 

        Console.WriteLine("\nGet ready to begin...");
        ShowSpinner(5);
    }

    public void DisplayFinishingMessage()
    {
        Console.WriteLine("\nWell done! You have completed the activity.");
        Console.WriteLine($"You just finished the {Name} for {Duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\rStarting in: {i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write($"\r{spinner[i % spinner.Length]} ");
            Thread.Sleep(250);
        }
        Console.WriteLine();
    }

    public abstract void Run();
}
