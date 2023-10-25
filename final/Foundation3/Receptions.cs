public class Receptions : Event
{
    private string _email;

    public Receptions(string email, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _email = email;
    }

   public void DisplayFullDetails()
    {
        Console.WriteLine("\nFull Details:");
        DisplayStandardInfo();
        //For receptions this includes an email for RSVP.
        Console.WriteLine($"RSVP {_email}");
    }
}