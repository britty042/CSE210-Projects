

class Program
{
    
    static void Main(string[] args)
    {
        int mindfulnessChoice = 0;

        while (mindfulnessChoice != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();
            mindfulnessChoice = int.Parse(userInput); 

            if (mindfulnessChoice == 1)
            {
                BreathingActivity breathe1 = new BreathingActivity();
                breathe1.Run();
                
            }
            
            else if (mindfulnessChoice == 2)
            {
                ReflectingActivity reflecting1 = new ReflectingActivity();
                reflecting1.Run();
            }

            else if (mindfulnessChoice == 3)
            {
                ListingActivity listing1 = new ListingActivity();
                listing1.Run();
            }
        }
    }
}
 
