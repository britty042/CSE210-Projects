public class Cycling : Activity
{
    private double _speed;
    public Cycling(double speed, string date, double minutes) : base(date, minutes)
    {
        _speed = speed;
    }

    public override string GetActivityName()
    {
        return nameof(Cycling);
    }

    public override double GetDistance()
    {
        return _activityMinutes * GetSpeed() / 60;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }
}