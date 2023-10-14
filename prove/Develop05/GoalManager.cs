using System.Collections.Concurrent;
using System.ComponentModel;
using System.IO;
using System.Xml;

public class GoalManager
{
    private int _score;
    private List<Goal> _goals = new();
    public int Score{get{return _score;}}

    public GoalManager(){}

    public void ListGoalDetails()
    {
        int number = 1;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{number}) {goal.GetDetailsString()}");
            number++;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The Types of Goals are:");
        Console.WriteLine("\t1. Simple Goal");
        Console.WriteLine("\t2. Eternal Goal");
        Console.WriteLine("\t3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        int input = int.Parse(Console.ReadLine());

        switch(input)
        {
            case 1:
                Console.Write("What is the name of your goal? ");
                string simple_name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string simple_description = Console.ReadLine();
                Console.Write("What is the amount of point associated with this goal? ");
                int simple_points = int.Parse(Console.ReadLine());
                SimpleGoal sg = new SimpleGoal(simple_name, simple_description, simple_points);
                _goals.Add(sg);
                break;
            case 2:
                Console.Write("What is the name of your goal? ");
                string eternal_name = Console.ReadLine();
                Console.Write("What is a short sectiption of it? ");
                string eternal_description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int eternal_points = int.Parse(Console.ReadLine());
                EternalGoal eg = new(eternal_name, eternal_description, eternal_points);
                _goals.Add(eg);
                break;
            case 3:
                Console.Write("What is the name of your goal? ");
                string checklist_name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string checklist_description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int checklist_points = int.Parse(Console.ReadLine());
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int checklist_target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int checklist_bonus = int.Parse(Console.ReadLine());
                CheckListGoal cg = new(checklist_name, checklist_description, checklist_points, checklist_target, checklist_bonus);
                _goals.Add(cg);
                break;
        }
    }

    public void RecordEvent()
    {   // 0 1 2 3 4...
        // X     Y

        // 1) X
        // 2) Y

        // 0  1  2  3
        // 0  3

        List<int> indexes = new();
        int counter = 1;    // the printed number of the goal
        int index = 0;      // The position of the goal in the goals list
        foreach(Goal goal in _goals)
        {
            if(!goal.IsComplete)
            {
                indexes.Add(index);
                Console.WriteLine($"{counter}) {goal.GetDetailsString()}");
                counter++;
            }
            index++;
        }
        int choice = int.Parse(Console.ReadLine());
        _score += _goals[indexes[choice - 1]].RecordEvent();
    }

    public void SaveGoals()
    {
        Console.Write("Please enter the name of the file you would like to save it as: ");
        string file_name = Console.ReadLine();
        using(StreamWriter io = new(file_name))
        {
            io.WriteLine(_score);
            foreach(Goal goal in _goals)
            {
                io.WriteLine(goal.GetSaveString());
            }
        }

    }

    public void LoadGoals() //bool initialLoad
    {
        Console.Write("Enter the name of the file you would like to load: ");
        string file_name = Console.ReadLine();
        //List<Entry> newEntries = new List<Entry>();
        string[] lines = System.IO.File.ReadAllLines(file_name);

        _score = int.Parse(lines[0]);
        bool skip = true;

        foreach (string line in lines)
        {
            if(skip)
            {
                skip = false;
                continue;
            }

            string[] parts = line.Split("|");

            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);
            //Console.WriteLine($"{name} ({description})");

            switch(parts[0])
            {
                case "Simple":
                    bool isComplete = bool.Parse(parts[4]);
                    SimpleGoal sg = new(name, description, points, isComplete);
                    _goals.Add(sg);
                    break;
                case "Eternal":
                    EternalGoal eg = new(name, description, points);
                    _goals.Add(eg);
                    break;
                case "Checklist":
                    isComplete = bool.Parse(parts[4]);
                    int amountCompleted = int.Parse(parts[5]);
                    int target = int.Parse(parts[6]);
                    int bonus = int.Parse(parts[7]);
                    CheckListGoal cg = new(name, description, points, isComplete, amountCompleted, target, bonus);
                    _goals.Add(cg);
                    break;
            }
        }
    }
}