class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;
    private int bonusPoints;

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints)
        : base(name, points)
    {
        this.targetCount = targetCount;
        this.currentCount = 0;
        this.bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        if (currentCount < targetCount)
        {
            currentCount++;
            if (currentCount == targetCount)
            {
                isCompleted = true;
                return points + bonusPoints; 
            }
            return points;
        }
        return 0; 
    }

    public override string GetStatus()
    {
        return isCompleted ? $"[X] {name} (Completed {targetCount}/{targetCount})"
                           : $"[ ] {name} (Completed {currentCount}/{targetCount})";
    }

    public override string SaveData()
    {
        return $"{base.SaveData()}|{targetCount}|{currentCount}|{bonusPoints}";
    }
}
