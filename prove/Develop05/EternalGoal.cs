public class EternalGoal : Goal
{
    public EternalGoal(string _name, string _description, int _points) : base(_name, _description, _points){}

    public override int RecordEvent()
    {
        Console.WriteLine($"Good job! You completed the goal and earned {_points} points!");
        return _points;
    }

    public override string GetDetailsString()
    {
        return $"    {_name} ({_description})";
    }

    public override string GetSaveString()
    {
       return $"Eternal|{_name}|{_description}|{_points}";
    }
}