using System;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") 
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();  
        Console.WriteLine("\nGet ready to begin...");
        ShowSpinner(3);

        int elapsedTime = 0;
        while (elapsedTime < Duration)
        {
            Console.WriteLine("\nBreathe in...");
            ShowCountdown(3);
            elapsedTime += 3;

            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
            elapsedTime += 3;
        }

        DisplayFinishingMessage(); 
    }
}
