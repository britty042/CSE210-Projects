using System.Configuration.Assemblies;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;



    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine($"\n{_description}");

         Console.Write("\nHow long, in seconds, would you like for your session? ");
        string userInput = Console.ReadLine();
        _duration = int.Parse(userInput);

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(2);

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell Done!");
        Console.WriteLine($"\nYou've completed {_duration} seconds of the {_name}.");
        ShowSpinner(5);
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        while (seconds > 0)
        {
            Console.Write("|");
            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("-");
            
            Thread.Sleep(500);
            Console.Write("\b \b");

            seconds -= 1;
        }
    }

    public void ShowCountDown(int seconds)
    {
        while (seconds > 0)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);

           int secondsLength = seconds.ToString().Length;

            while (secondsLength > 0)
            {
            Console.Write("\b \b");
            secondsLength -= 1;
            }
        
        seconds -= 1;
        }
    }
}
