using System;
using System.Collections.Generic;
using System.Threading;

class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() 
        : base("Listing Activity", "This activity helps you reflect on the good things in your life by listing as many things as you can in a certain area.") 
    {
    }

    public override void Run()
    {
        DisplayStartingMessage(); 

        Console.WriteLine("\nThis activity will help you reflect on the good things in your life by listing as many things as you can in a certain area.");

        string prompt = GetRandomPrompt();
        Console.WriteLine($"\nPrompt: {prompt}");

        Console.WriteLine("\nGet ready to think about your response...");
        ShowCountdown(3);

        Console.WriteLine("\nStart listing items. Press Enter after each one. Type 'done' to finish early.");
        List<string> responses = new List<string>();

        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < Duration)
        {
            string response = Console.ReadLine();
            if (response.ToLower() == "done") break;
            if (!string.IsNullOrWhiteSpace(response)) responses.Add(response);
        }

        Console.WriteLine($"\nYou listed {responses.Count} items. Well done!");
        ShowSpinner(3);
        DisplayFinishingMessage(); 
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return prompts[random.Next(prompts.Count)];
    }
}
