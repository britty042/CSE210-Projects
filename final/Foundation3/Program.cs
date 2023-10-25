using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("702 East Mutton Road", "Concord", "Connecticut");
        Receptions reception1 = new Receptions("weddings4you@gmail.com",
            "Emry & Lawson Wedding",
            "Reception held after temple ceremony.  Theme: simple & elegant",
            "12/07/2023",
            "6:00-8:00 PM",
            address1);
        Console.WriteLine("\nStandard Information: ");
        reception1.DisplayStandardInfo();
        reception1.DisplayFullDetails();
        reception1.DisplayShortDescription("Reception");

        Address address2 = new Address("2708 North 114700 South", "West Creek", "Kansas");
        Lectures lecture1 = new Lectures("Jacob T. Child",
            "CEO Child Industries",
            "Effective Time Management",
            "A lecture on time management skills and benefits",
            "1/19/2024", "7:00 PM", address2);
        Console.WriteLine("\nStandard Information: ");
        lecture1.DisplayStandardInfo();
        lecture1.DisplayFullDetails();
        lecture1.DisplayShortDescription("Lecture");

        Address address3 = new Address("1985 South 2225 East", "Cobblestone", "Indiana");
        OutdoorGatherings outdoor1 = new OutdoorGatherings("Sunny weather predicted",
            "Tea in Hyde Park",
            "Tea in the park with friends. All dog friends invited to attend.  Dog treats available for purchase.",
            "10/29/2023",
            "3:00 PM",
            address3);
        Console.WriteLine("\nStandard Information: ");
        outdoor1.DisplayStandardInfo();
        outdoor1.DisplayFullDetails();
        outdoor1.DisplayShortDescription("Outdoor Gathering");
    }
}