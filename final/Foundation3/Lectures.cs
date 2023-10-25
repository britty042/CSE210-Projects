public class Lectures : Event
{
    private string _speakerName;
    private string _capacity;

    public Lectures(string speakerName, string capacity, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine("\nFull Details:");
        DisplayStandardInfo();
        //For lectures, this includes the speaker name and capacity.
        Console.WriteLine($"Speaker: {_speakerName}");
        Console.WriteLine($"Capacity: {_capacity}");
    }
} 
