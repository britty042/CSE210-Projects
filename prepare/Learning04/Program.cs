using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new Assignment("Brittney", "Math");
        Console.WriteLine(assign1.GetSummary());

        MathAssignment mathassign1 = new MathAssignment("Brittney", "Math", "Section 7.3", "8-19");
        Console.WriteLine(mathassign1.GetSummary());
        Console.WriteLine(mathassign1.GetHomeworkList());
    }
}