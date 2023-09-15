using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string input = Console.ReadLine();
        // int magicNumber = int.Parse(input);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guessNumber = -1;
        
        do
        {
            Console.Write("Guess a number bewtween 1 & 100? ");
            guessNumber = int.Parse(Console.ReadLine());
        
            if(magicNumber > guessNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guessNumber)
            {
                Console.WriteLine("Lower");
            }
        } while (guessNumber != magicNumber);   
        
        Console.WriteLine("You guessed it!  Nice work!");
    }
}