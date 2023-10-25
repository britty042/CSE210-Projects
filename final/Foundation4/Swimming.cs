public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(int numberOfLaps, string date, double minutes) : base(date, minutes)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override string GetActivityName()
    {
        return nameof(Swimming);
    }

    public override double GetDistance()
    {
        return _numberOfLaps * 50 / 1000 * 0.62;
    }
}