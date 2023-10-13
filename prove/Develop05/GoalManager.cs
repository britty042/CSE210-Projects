using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    
    private int _score; 

    public GoalManager()
    {
        _score = 0;
    }

    //Start - This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
    public void Start()
    {
        

        int menuChoice = 0;
        while (menuChoice != 6)
        {
            Console.WriteLine($"\nYou have {_score} points");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu:");
            menuChoice = int.Parse(Console.ReadLine());
            
            if (menuChoice == 1)
            {
                CreateGoal();
            }

            else if (menuChoice == 2)
            {
                ListGoalDetails();
            }

            else if (menuChoice == 3)
            {
                Console.Write("What is the file name you'd like to save to? ");
                string fileName = Console.ReadLine();
                SaveGoals(fileName);
            }

            else if (menuChoice == 4)
            {
                Console.Write("What is the file name? ");
                string fileName = Console.ReadLine();
                LoadGoals(fileName);
            }

            else if (menuChoice == 5)
            {
                RecordEvent();
            }
        }
    }
//DisplayPlayerInfo - Displays the players current score.
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }
//ListGoalNames - Lists the names of each of the goals.
    public void ListGoalNames()
    {
        int number = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{number}. {goal.GetName()}");
            number += 1;
        }
    }
//ListGoalDetails - Lists the details of each goal (including the checkbox of whether it is complete).
    public void ListGoalDetails()
    {
        int number = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{number}. {goal.GetDetailsString()}");
            number += 1;
        }
    }
//CreateGoal - Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int newgoal = int.Parse(Console.ReadLine());

        Console.Write("\nWhat is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Goal goal;
    
        if (newgoal == 1)
        {
            goal = new SimpleGoal(name, description, points);
            _goals.Add(goal);
        }

        else if (newgoal == 2)
        {
            goal = new EternalGoal(name, description, points);
            _goals.Add(goal);
        }

        else if (newgoal == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            goal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(goal);
        }
    }
//RecordEvent - Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
    public void RecordEvent()
    {
        ListGoalNames();
        
        Console.Write("\nWhich numbered goal would you like to record? ");
        int recordGoal = int.Parse(Console.ReadLine());
        
        Goal retrievedGoal = _goals[recordGoal-1];
        retrievedGoal.RecordEvent(); 
        Console.WriteLine($"You received {retrievedGoal.GetPoints()} points.");

        _score += retrievedGoal.GetPoints();
    }
//SaveGoals - Saves the list of goals to a file.
    public void SaveGoals(string fileName)
    { 
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }
        }    
    }
//LoadGoals - Loads the list of goals from a file.
    public void LoadGoals(string fileName)
    {
        string[] linesFromFile = System.IO.File.ReadAllLines(fileName);

        bool onFirstLine = true;

        foreach(string currentLine in linesFromFile)
        {   
            if (onFirstLine == true)
            {
                _score = int.Parse(currentLine);
                onFirstLine = false;
            }
             
            else
            {
                string[] splitLine = currentLine.Split("|");
            
                if (splitLine[0] == nameof (SimpleGoal))
                {
                    Goal simple = new SimpleGoal(splitLine[1], splitLine[2], int.Parse(splitLine[3]), bool.Parse(splitLine[4]));
                    _goals.Add(simple);
                }

                else if (splitLine[0] == nameof (EternalGoal))
                {
                    Goal eternal = new EternalGoal(splitLine[1], splitLine[2], int.Parse(splitLine[3]));
                    _goals.Add(eternal);
                }

                else if (splitLine [0] == nameof (ChecklistGoal))
                {
                    string shortName = splitLine[1];
                    string description = splitLine[2];
                    int points = int.Parse(splitLine[3]);
                    int bonus = int.Parse(splitLine[4]);
                    int amountCompleted = int.Parse(splitLine[5]);
                    int target = int.Parse(splitLine[6]);

                    Goal checklist = new ChecklistGoal(shortName, description, points, target, bonus, amountCompleted);
                    _goals.Add(checklist);
                }
            }    
        }    
    }
}