using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        
        string grade = "";

        if (number >= 90)
        {
            grade = "A"; 
        }
        else if (number >= 80)
        {
            grade = "B"; 
        }
        else if (number >= 70)
        {
            grade = "C";         
        }
        else if (number >= 60)
        {
            grade = "D";         
        }
        else
        {
            grade = "F";         
        }
        Console.WriteLine($"This is your grade: {grade}");

        if (number > 70)
        {
            Console.WriteLine($"Congrats!  You passed!");
        }
        else
        {
            Console.WriteLine($"Don't quit!  You'll do better next time!");
        }
    }
}