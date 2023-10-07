using System;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> activityLog = new()
        {
            {"Breathing", 0},
            {"Reflecting", 0},
            {"Listing", 0}
        };

        while (true)
        {
            // Add the while loop ( while(true) )
            //Console.WriteLine("Hello Develop04 World!");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Start breathing activity");
            Console.WriteLine("\t2. Start reflecting activity");
            Console.WriteLine("\t3. Start listing activity");
            Console.WriteLine("\t4. Show Activity Log");
            Console.WriteLine("\t5. Quit");
            Console.Write("Select a choice from the menu: ");
            int input = int.Parse(Console.ReadLine());


            switch(input)
            {
                case 1:
                    BreathingActivity breathing = new();
                    breathing.Run();
                    activityLog["Breathing"]++;
                    break;
                case 2:
                    ReflectingActivity reflecting = new();
                    reflecting.Run();
                    activityLog["Reflecting"]++;
                    break;
                // Add other case statements
                case 3:
                    ListingActivity listing = new();
                    listing.Run();
                    activityLog["Listing"]++;
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Activity Log");
                    foreach(var pair in activityLog)
                    {
                        Console.WriteLine($"{pair.Key}: {pair.Value}");
                    }
                    Console.Write("\nPress 'Enter' to continue");
                    string userInput = Console.ReadLine();
                    Console.Clear();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Select a valid option");
                    break;
        }

        }
    }
}