public class OutdoorGatherings : Event
{
    private string _weather;

    public OutdoorGatherings(string weather) : base()
    {
        _title = "Tea in Hyde Park";
        _description = "Tea in the park with friends. All dog friends invited to attend.  Dog treats available for purchase.";
        _date = "10/29/2023";
        _time = "3:00 PM";
        _weather = weather;
    }
} 