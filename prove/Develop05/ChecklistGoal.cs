public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;


    public CheckListGoal(string _name, string _description, int _points, int _target, int _bonus) : base(_name, _description, _points)
    {
        //Initialize values
        this._bonus = _bonus;
        this._target = _target;

    }

    public CheckListGoal(string _name, string _description, int _points, bool _isComplete, int _amountCompleted, int _target, int _bonus) : base(_name, _description, _points, _isComplete)
    {
        //Initialize values
        this._amountCompleted = _amountCompleted;
        this._target = _target;
        this._bonus = _bonus;
    }

    public override int RecordEvent()
    {
        // PUT How many times have you completed the goal?
        // times = GET
        // IF times >= target
        //      isComplete = true
        //      PUT message
        //      RETURN points + bonus
        // ELSE
        //      PUT message
        //      RETURN points
        //_amountcompleted = 0;
        Console.Write("How many times have you completed the goal? ");
        int times = int.Parse(Console.ReadLine());
        _amountCompleted += times;
        if (_amountCompleted >= _target)
        {
            _isComplete = true;
            Console.Clear();
            Console.WriteLine($"\nCongrats! You've earned {_points * times} points and your bonus points of {_bonus}!");
            return (_points * times) + _bonus;
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"\nCongrats! You've earned {_points * times} points!");
            return _points * times;
        }
    }

    public override string GetDetailsString()
    {
        char _;
        if(_isComplete)
            _ = 'X';
        else
            _ = ' ';
        return $"[{_}] {_name} ({_description}) {_amountCompleted}/{_target}";
    }

    public override string GetSaveString()
    {
        return $"Checklist|{_name}|{_description}|{_points}|{_isComplete}|{_amountCompleted}|{_target}|{_bonus}";
    }
}