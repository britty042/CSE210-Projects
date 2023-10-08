using System.Net;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "How do you feel loved?",
        "When have you felt the Holy Ghost recently?",
        "What have you felt most grateful for recently?",
        "What are the positive moments you've experienced today?",
        "What are you doing well recently?",
        "How have you felt God's love for you recently?",
    };


    public ListingActivity() : base()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in reponse to the prompt.";
        _duration = 0;
    }

    public void Run()
    {
        DisplayStartingMessage();


        //Display a random prompt here
        Console.WriteLine("\nList as many responses as you can to the following prompt:");

        GetRandomPrompt();

        Console.Write("\nYou may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        
        _count = 0;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        //run until the received time runs out
        while (DateTime.Now < endTime)
        {
            //show a carrot to start and on each new line(once they press enter)
            Console.Write(">");
            Console.ReadLine();
                      
            _count += 1;

        }
             
        // Diplay how many things they listed.

        Console.WriteLine($"\nYou listed {_count} items.");

        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        //the guide says this should be void and return nothing.  That doesn't make sense.  How would it print the prompt?
        Random randomGenerator = new Random();
        int promptIndex = randomGenerator.Next(0, _prompts.Count);

        Console.WriteLine($"---{_prompts[promptIndex]}---");
    }
}