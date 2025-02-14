using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int totalScore = 0;
    private int level = 1;
    private const string FilePath = "goals.txt";

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            int pointsEarned = goals[goalIndex].RecordEvent();
            totalScore += pointsEarned;
            UpdateLevel();
        }
    }

    private void UpdateLevel()
    {
        int newLevel = (totalScore / 100) + 1;
        if (newLevel > level)
        {
            level = newLevel;
            Console.WriteLine($"Congrats! You reached Level {level}!");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()}");
        }
        Console.WriteLine($"Total Score: {totalScore} | Level: {level}");
    }

    public void SaveGoals()
    {
        List<string> lines = new List<string> { $"{totalScore}|{level}" };
        foreach (var goal in goals)
        {
            lines.Add(goal.SaveData());
        }
        File.WriteAllLines(FilePath, lines);
    }

    public void LoadGoals()
    {
        if (!File.Exists(FilePath)) return;

        string[] lines = File.ReadAllLines(FilePath);
        string[] stats = lines[0].Split('|');
        totalScore = int.Parse(stats[0]);
        level = int.Parse(stats[1]);

        goals.Clear();
        for (int i = 1; i < lines.Length; i++)
        {
            goals.Add(Goal.LoadData(lines[i]));
        }
    }
}
