public abstract class Activity
{
    private DateTime date;
    private int durationInMinutes;

    public Activity(DateTime date, int durationInMinutes)
    {
        this.date = date;
        this.durationInMinutes = durationInMinutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();


    public string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")} {GetType().Name} ({durationInMinutes} min): " +
               $"Distance {GetDistance()} {GetDistanceUnit()}, " +
               $"Speed: {GetSpeed()} {GetSpeedUnit()}, " +
               $"Pace: {GetPace()} min per {GetPaceUnit()}";
    }


    protected virtual string GetDistanceUnit() => "miles";
    protected virtual string GetSpeedUnit() => "mph";
    protected virtual string GetPaceUnit() => "mile";

    protected int DurationInMinutes => durationInMinutes;
}
