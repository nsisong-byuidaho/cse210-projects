using System;
// EXCEEDING REQUIREMENT;

//  For the exceeding requirement part of the program, I Implemented a Leveling System which include;
//    - Users level up every 100 points earned.
//    - Displays a notification when leveling up.
//    - Adds excitement and motivation to goal tracking.
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.LoadGoals();

        while (true)
        {
            Console.WriteLine("\nWelcome to My Eternal Quest - Goal Tracker");
            Console.WriteLine("1. Add a new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Show goals & progress");
            Console.WriteLine("4. Save and exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddNewGoal(manager);
                    break;
                case "2":
                    RecordGoalEvent(manager);
                    break;
                case "3":
                    manager.DisplayGoals();
                    break;
                case "4":
                    manager.SaveGoals();
                    Console.WriteLine("✅ Save Completed. See you next time!");
                    return;
                default:
                    Console.WriteLine("❌ Invalid choice. Try again.");
                    break;
            }
        }
    }

    static void AddNewGoal(GoalManager manager)
    {
        Console.WriteLine("\n Please choose a goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Your choice: ");
        string goalType = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter point value: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        switch (goalType)
        {
            case "1":
                newGoal = new SimpleGoal(name, points);
                break;
            case "2":
                newGoal = new EternalGoal(name, points);
                break;
            case "3":
                Console.Write("Enter number of times needed to complete: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points upon completion: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, points, targetCount, bonusPoints);
                break;
            default:
                Console.WriteLine("❌ Invalid goal type.");
                return;
        }

        manager.AddGoal(newGoal);
        Console.WriteLine("✅ Goal added successfully!");
    }

    static void RecordGoalEvent(GoalManager manager)
    {
        manager.DisplayGoals();
        Console.Write("Enter the number of the goal you completed: ");
        int index = int.Parse(Console.ReadLine()) - 1;
        
        manager.RecordEvent(index);
    }
}
    
