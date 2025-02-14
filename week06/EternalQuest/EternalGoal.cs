class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override int RecordEvent()
    {
        return points;
    }

    public override string GetStatus()
    {
        return $"[∞] {name}";
    }

    public override string SaveData()
    {
        return base.SaveData();
    }
}
