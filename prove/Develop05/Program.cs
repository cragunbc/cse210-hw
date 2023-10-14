using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop05 World!");
        GoalManager manager = new();
        while(true)
        {
            Console.WriteLine($"\nScore: {manager.Score}\n");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("\t1. Create New Goal");
            Console.WriteLine("\t2. List Goals");
            Console.WriteLine("\t3. Save Goals");
            Console.WriteLine("\t4. Load Goals");
            Console.WriteLine("\t5. Record Event");
            Console.WriteLine("\t6. Quit");
            Console.Write("Please select a menu option: ");
            int input = int.Parse(Console.ReadLine());

            
            switch(input)
            {
                case 1:
                    Console.Clear();
                    manager.CreateGoal();
                    break;
                case 2:
                    Console.Clear();
                    manager.ListGoalDetails();
                    break;
                case 3:
                    Console.Clear();
                    manager.SaveGoals();
                    break;
                case 4:
                    Console.Clear();
                    manager.LoadGoals();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Select a goal to record:\n");
                    manager.RecordEvent();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Select a valid option");
                    break;
            }
        }
    }
}