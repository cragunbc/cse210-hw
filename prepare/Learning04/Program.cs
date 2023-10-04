using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");
        Assignment a1 = new Assignment("Brantley", "Science");
        Console.WriteLine(a1.GetSummary());

        MathAssignment m1 = new MathAssignment("Brantley", "Science", "27", "3");
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());
 
        WritingAssignment w1 = new WritingAssignment("Brantley", "World History", "The World History 101");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());

    }
}