using System;

public class Program
{
    static void Main(string[] args)
    {
        Journal currentJournal = new Journal();
        int numberChoice = 0;
        while (numberChoice != 5)
        {
            Console.WriteLine("Welcome to the Journal!");
            Console.WriteLine("Please select one of the following options: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do with your journal? ");
            string userInput = Console.ReadLine();
            numberChoice = int.Parse(userInput);        
        
            //If you want to write in your journal//
            if (numberChoice == 1)
            {
                PromptGenerator randomPrompt= new PromptGenerator();
                string prompt = randomPrompt.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string entryResponse = Console.ReadLine();
                
                Console.WriteLine("What are you most grateful for today? ");
                Console.Write(">");
                string gratitudeResponse = Console.ReadLine();

                Entry currentEntry = new Entry();
                DateTime theCurrentTime = DateTime.Now;
                currentEntry._date = theCurrentTime.ToShortDateString();
                currentEntry._promptText = prompt;
                currentEntry._response = entryResponse;
                currentEntry._gratitude = gratitudeResponse;

                currentJournal.AddEntry(currentEntry);
            }

            //If you want to  display your journal//
            else if (numberChoice == 2)
            {
                currentJournal.DisplayAll();
            }

            //If you want to load a previously saved journal//
            else if (numberChoice == 3)
            {
                Console.Write("What file would you like to load? ");
                string fileName = Console.ReadLine();

                currentJournal.LoadFromFile(fileName);
            }

            //If you want to save your journal//
            else if (numberChoice == 4)
            {
                Console.Write("Please enter the file name: ");
                string fileName = Console.ReadLine();

                currentJournal.SaveToFile(fileName);
            }

        }
    }
}