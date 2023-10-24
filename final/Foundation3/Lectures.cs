public class Lectures : Event
{
    private string _speakerName;
    private string _capacity;

    public Lectures(string speakerName, string capacity) : base()
    {
        _title = "Effective Time Management";
        _description = "A lecture on time management skills and benefits";
        _date = "1/19/2024";
        _time = "7:00 PM";
        _speakerName = speakerName;
        _capacity = capacity;
    }
} 
