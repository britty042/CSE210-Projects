using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        
        Reference reference1 = new Reference("1 Nephi", 3, 7);
        Scripture scripture1 = new Scripture(reference1, @"And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, 
        for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

        Reference reference2 = new Reference("2 Nephi", 4, 34);
        Scripture scripture2 = new Scripture(reference2, @"O Lord, I have atrusted in thee, and I will btrust in thee forever. I will not put my ctrust in the arm of flesh; 
        for I know that cursed is he that putteth his dtrust in the arm of flesh. Yea, cursed is he that putteth his trust in man or maketh flesh his arm.");

        Reference reference3 = new Reference("Mosiah", 2, 41);
        Scripture scripture3 = new Scripture(reference3, @"And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. 
        For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with 
        God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it.");
   

        string endProgram = "";
       
        while (endProgram.ToLower() != "quit")
        {
            int scriptureChoice = 0;
            
            Console.WriteLine("Welcome to the Scripture Memorizing Program!");
            
            Console.WriteLine($"1. {reference1.GetDisplayText()}");
            Console.WriteLine($"2. {reference2.GetDisplayText()}");
            Console.WriteLine($"3. {reference3.GetDisplayText()}");
            Console.WriteLine("4. Quit Program");
        
            Console.Write("Which scripture would you like to memorize? ");
            string userInput = Console.ReadLine();
            scriptureChoice = int.Parse(userInput); 

            if (scriptureChoice == 1)
            {
                Console.Clear();
                Console.WriteLine(scripture1.GetDisplayText());

                while (endProgram.ToLower() != "quit" && scripture1.IsCompletelyHidden() == false)
                {
                    Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
                    Console.ReadLine();
                    Console.Clear();
                    scripture1.HideRandomWords(3);
                    Console.WriteLine(scripture1.GetDisplayText());
                }
            }

            else if (scriptureChoice == 2)
            {
                Console.Clear();
                Console.WriteLine(scripture2.GetDisplayText());

                while (endProgram.ToLower() != "quit" && scripture2.IsCompletelyHidden() == false)
                {
                    Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
                    Console.ReadLine();
                    Console.Clear();
                    scripture2.HideRandomWords(3);
                    Console.WriteLine(scripture2.GetDisplayText());
                }
            }

            else if (scriptureChoice == 3)
            {
                Console.Clear();
                Console.WriteLine(scripture3.GetDisplayText());

                while (endProgram.ToLower() != "quit" && scripture3.IsCompletelyHidden() == false)
                {
                    Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
                    Console.ReadLine();
                    Console.Clear();
                    scripture3.HideRandomWords(3);
                    Console.WriteLine(scripture3.GetDisplayText());
                }
            }

            else
            {
                endProgram = "quit";
            }
        }
    }
}