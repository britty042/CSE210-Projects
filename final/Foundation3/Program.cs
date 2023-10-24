using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("702 East Mutton Road", "Concord", "Connecticut");
        Event reception1 = new Receptions("weddings4you@gmail.com");
        Console.WriteLine("Standard Information: ");
        reception1.DisplayStandardInfo();
        Console.WriteLine($"Location: {address1.Display()}");
        Console.WriteLine();
        Console.WriteLine("Short Description: ");
        reception1.DisplayShortDescription("Reception");
        Console.WriteLine();

        Address address2 = new Address("2708 North 114700 South", "West Creek", "Kansas");
        Event lecture1 = new Lectures("Jacob T. Child", "CEO Child Industries");
        Console.WriteLine("Standard Information: ");
        lecture1.DisplayStandardInfo();
        Console.WriteLine($"Location: {address2.Display()}");
        Console.WriteLine();
        Console.WriteLine("Short Description: ");
        lecture1.DisplayShortDescription("Lecture");
        Console.WriteLine();

        Address address3 = new Address("1985 South 2225 East", "Cobblestone", "Indiana");
        Event outdoor1 = new OutdoorGatherings("Sunny weather predicted");
        Console.WriteLine("Standard Information: ");
        outdoor1.DisplayStandardInfo();
        Console.WriteLine($"Location: {address3.Display()}");
        Console.WriteLine();
        Console.WriteLine("Short Description: ");
        outdoor1.DisplayShortDescription("Outdoor Gathering");
        Console.WriteLine();
    }
}