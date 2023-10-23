public class Running : Activity
{

    private double _distance;

    public Running(double activityLength, string date, double distance) : base(activityLength, date)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (_activityLength / 60);
    }

    public override double GetPace()
    {
        return _activityLength / GetDistance();
    }
}