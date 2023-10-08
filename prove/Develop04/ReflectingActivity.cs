using System.ComponentModel;
using System.Security.Cryptography;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you did something really difficult.",
        "Think of a time when you found yourself full of doubt.",
        "Think of a time when you faced a challenge that seemed unending.",
        "Think of a time when you felt unable to rise to a challenge.",
        "Think of a time when you felt God had abandoned you."
    };
    private List<string> _questions = new List<string>
    {
        "How did you feel when you had made it through?",
        "What was your biggest regret about your response?",
        "How do you feel about the situation looking back?",
        "Who were your biggest supporters throughout this situation?",
        "What were the lessons you learned?"
    };

    private Random _randomQuestion;

    public ReflectingActivity() : base()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience.  This will help you recognise the power you have and how you can use it in other aspects of your life.";
        _duration = 0;
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nConsider the following prompt:");

        
        DisplayPrompt();
        
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.Write("\nYou may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        _randomQuestion = new Random();
        
        int questionDuration = _duration / _questions.Count;
        if(questionDuration < 10)
        {
            questionDuration = 10;
        }

        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            ShowSpinner(questionDuration);
        }


        DisplayEndingMessage();    
    }          
    

    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int promptIndex = randomPrompt.Next(0, _prompts.Count);
        string prompt  = _prompts[promptIndex];

        return prompt;       
    }

    public string GetRandomQuestion()
    {
        int questionIndex = _randomQuestion.Next(0, _questions.Count);
        string question  = _questions[questionIndex];

        return question;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"---{GetRandomPrompt()}---");
    }

    public void DisplayQuestion()
    {
        Console.WriteLine($">{GetRandomQuestion()}");
    }
}