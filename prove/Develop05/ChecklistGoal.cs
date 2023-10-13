public class CheckListGoal : Goal
{
    private int _amountcompleted;
    private int _target;
    private int _bonus;



    public CheckListGoal(string _name, string _description, int _points, int _target, int _bonus) : base(_name, _description, _points)
    {
        //Initialize values
    }

    public CheckListGoal(string _name, string _description, int _points, bool _isComplete, int _amountcompleted, int _target, int _bonus) : base(_name, _description, _points, _isComplete)
    {
        //Initialize values
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
    }

    public override string GetSaveString()
    {
        return $"Checklist|{_name}|{_description}|{_points}|{_isComplete}";
    }
}