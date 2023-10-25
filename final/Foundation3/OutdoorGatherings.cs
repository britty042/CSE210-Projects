public class OutdoorGatherings : Event
{
    private string _weather;

    public OutdoorGatherings(string weather, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _title = "Tea in Hyde Park";
        _description = "Tea in the park with friends. All dog friends invited to attend.  Dog treats available for purchase.";
        _date = "10/29/2023";
        _time = "3:00 PM";
        _weather = weather;
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine("\nFull Details:");
        DisplayStandardInfo();
        // For outdoor gatherings, this includes a statement of the weather.
        Console.WriteLine($"Weather: {_weather}");
    }
} 