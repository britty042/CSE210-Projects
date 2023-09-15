using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished:");

        int numberEntered = -1;

        while (numberEntered != 0)
        {
            Console.Write("Enter Number:");
            numberEntered = int.Parse(Console.ReadLine());

            numbers.Add(numberEntered);
        }

        int sum = 0;
        int largestNumber = -999999999;
        foreach (int number in numbers)
        {
            sum += number;
            if (number > largestNumber)
            largestNumber = number;
        }

        Console.WriteLine($"The sum of the list is {sum}");

        int average = sum/numbers.Count;
        Console.WriteLine($"The average of the list is {average}");
        Console.WriteLine($"The largest number in the list is {largestNumber}");

    }
}