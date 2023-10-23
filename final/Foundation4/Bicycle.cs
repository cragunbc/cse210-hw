public class Bicyle : Activity
{
    private double _speed;


    public Bicyle(double activityLength, string date, double speed) : base(activityLength, date)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * (_activityLength / 60);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return _activityLength / GetDistance();
    }
}