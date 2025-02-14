class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override int RecordEvent()
    {
        if (!isCompleted)
        {
            isCompleted = true;
            return points;
        }
        return 0; 
    }

    public override string GetStatus()
    {
        return isCompleted ? $"[X] {name}" : $"[ ] {name}";
    }

    public override string SaveData()
    {
        return base.SaveData();
    }
}
