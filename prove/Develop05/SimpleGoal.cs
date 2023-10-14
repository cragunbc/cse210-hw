using System.Collections.Concurrent;

public class SimpleGoal : Goal
{
    public SimpleGoal(string _name, string _description, int _points) : base(_name, _description, _points){}
    public SimpleGoal(string _name, string _description, int _points, bool _isComplete) : base(_name, _description, _points, _isComplete){}

    public override int RecordEvent()
    {
        _isComplete = true;
        Console.Clear();
        Console.WriteLine($"\nGood job! You completed the goal and earned {_points} points!");
        return _points;
    }

    public override string GetSaveString()
    {
        return $"Simple|{_name}|{_description}|{_points}|{_isComplete}";
    }
}