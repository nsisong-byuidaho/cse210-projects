using System;

abstract class Goal
{
    protected string name;
    protected int points;
    protected bool isCompleted;

    public Goal(string name, int points)
    {
        this.name = name;
        this.points = points;
        this.isCompleted = false;
    }

    public abstract int RecordEvent(); 

    public abstract string GetStatus();

    public virtual string SaveData() 
    {
        return $"{this.GetType().Name}|{name}|{points}|{isCompleted}";
    }

    public static Goal LoadData(string data)
    {
        string[] parts = data.Split('|');
        string type = parts[0];
        string name = parts[1];
        int points = int.Parse(parts[2]);
        bool isCompleted = bool.Parse(parts[3]);

        switch (type)
        {
            case "SimpleGoal": return new SimpleGoal(name, points) { isCompleted = isCompleted };
            case "EternalGoal": return new EternalGoal(name, points);
            case "ChecklistGoal": return new ChecklistGoal(name, points, int.Parse(parts[4]), int.Parse(parts[5]));
            default: throw new Exception("Invalid goal type");
        }
    }
}
