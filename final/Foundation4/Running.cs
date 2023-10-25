public class Running : Activity
{
    private double _distance;
    public Running(double distance, string date, double minutes) : base(date, minutes)
    {
        _distance = distance;
    }

    public override string GetActivityName()
    {
        return nameof(Running);
    }

    public override double GetDistance()
    {
        return _distance;
    }
}