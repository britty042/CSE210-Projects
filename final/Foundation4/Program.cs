using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Activity cycling = new Cycling(10.5, "24 October 2023", 30);
        Activity running = new Running(26.2, "25 October 2023", 120);
        Activity swimming = new Swimming(20, "26 October 2023", 30);
        activities.Add(cycling);
        activities.Add(running);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }
    }
}