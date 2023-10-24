using System.Net.Sockets;
using System.Reflection;

public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;



    public void DisplayStandardInfo()
    {
//Lists the title, description, date, time, and address.
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"When: {_date} at {_time}");
        
    }

    public void DisplayFullDetails()
    {
        //Lists all of the above, plus type of event and information specific to that event type. For lectures, 
        //this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather.
    }

    public void DisplayShortDescription(string type)
    {
        //Lists the type of event, title, and the date.
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"When: {_date}");
    }
}