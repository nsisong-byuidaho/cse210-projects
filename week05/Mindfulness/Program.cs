using System;
using System.Collections.Generic;
// For the extra creativity, I have added the view Activity History in the Menu. 
// It keeps track of how many times each activity has been performed and allows users 
// to view the history by selecting option 4 in the menu.
class Program
{
    static void Main()
    {
        Dictionary<string, int> activityHistory = new Dictionary<string, int>();
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. View Activity History");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            
            string choice = Console.ReadLine();
            Activity activity = null;
            string activityName = "";
            
            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    activityName = "Breathing Activity";
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    activityName = "Reflection Activity";
                    break;
                case "3":
                    activity = new ListingActivity();
                    activityName = "Listing Activity";
                    break;
                case "4":
                    Console.WriteLine("\nActivity History:");
                    foreach (var entry in activityHistory)
                    {
                        Console.WriteLine($"{entry.Key}: {entry.Value} times");
                    }
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    continue;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }
            
            activity.Run();
            
            if (activityHistory.ContainsKey(activityName))
            {
                activityHistory[activityName]++;
            }
            else
            {
                activityHistory[activityName] = 1;
            }
        }
    }
}
