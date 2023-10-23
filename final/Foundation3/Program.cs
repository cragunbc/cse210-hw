using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation3 World!");
        Lecture l1 = new("Motivational Speaker", "A local member of our community is coming back to speak to us on how to face challenges", "10/13/2023", "7:00pm",  new Address("1234 S. St", "Salt lake"), "John Jones", 150);
        Console.WriteLine($"\nStandard Details: {l1.StandardDetails()}");
        Console.WriteLine($"\nFull Details: {l1.GetFullDetails()}");
        Console.WriteLine($"\nShort Details: {l1.Short()}");

        Reception r1 = new("Dave Nelson's and Stephanie Jones's Wedding", "Please come and join us to celebrate these two!", "12/15/2023", "5:00pm", new Address("5678 E Antelop Dr.", "Portland"), "bigtimeballer@gmail.com");
        Console.WriteLine($"\nStandard Details: {r1.StandardDetails()}");
        Console.WriteLine($"\nFull Details: {r1.GetFullDetails()}");
        Console.WriteLine($"\nShort Details: {r1.Short()}");

        OutdoorGathering o1 = new("John's Eagle Scout Court of Honor", "John is getting his Eagle Scout award. Please come!", "3/25/2024", "6:00pm", new Address("1120 E North Rd.", "Rexburg"), 50, "The weather is supposed to be sunny with a high of 85 degrees");
        Console.WriteLine($"\nStandard Details: {o1.StandardDetails()}");
        Console.WriteLine($"\nFull Details: {o1.GetFullDetails()}");
        Console.WriteLine($"\nShort Details: {o1.Short()}");
    }
}