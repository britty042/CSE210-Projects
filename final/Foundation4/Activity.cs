using System.Xml.Serialization;

public abstract class Activity
{
    protected string _date;
    protected double _activityMinutes;
    public Activity(string date, double activityMinutes)
    {
        _date = date;
        _activityMinutes = activityMinutes;
    }

    public abstract string GetActivityName();

    public abstract double GetDistance();

    public virtual double GetSpeed()
    {
        return 60 / GetPace();
    }

    public virtual double GetPace()
    {
        return _activityMinutes / GetDistance();
    }

    public void GetSummary()
    {
        Console.WriteLine($"{_date} {GetActivityName()}({_activityMinutes} min)-Distance {GetDistance()} miles, Speed {Math.Round(GetSpeed(), 2)} mph, Pace {Math.Round(GetPace(), 2)} min per mile");
    }
}