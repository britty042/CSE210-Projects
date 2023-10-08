using System.Reflection.Metadata;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();       

        int amountToBreatheIn = 4;
        int amountToBreatheOut = 6;

        int breathingTime = _duration/(amountToBreatheIn + amountToBreatheOut);

        while (breathingTime > 0)
        {
            Console.Write("\nBreathe in: ");
            ShowCountDown(amountToBreatheIn);
            Console.Write("\nBreathe out: ");
            ShowCountDown(amountToBreatheOut); 
            breathingTime -= 1;      
        }

        DisplayEndingMessage();   
    }   
}
