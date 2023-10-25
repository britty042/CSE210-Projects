using System.Net.Sockets;
using System.Reflection;

public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void DisplayStandardInfo()
    {
        //Lists the title, description, date, time, and address.
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"When: {_date} at {_time}");
        Console.WriteLine($"Where: {_address.Display()}");
    }

    public void DisplayShortDescription(string type)
    {
        //Lists the type of event, title, and the date.
        Console.WriteLine("\nShort Description: ");
        Console.WriteLine($"{type}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"When: {_date}");
    }
}