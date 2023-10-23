public class Swimming : Activity
{
    private double _laps;

    public Swimming(double activityLength, string date, double laps) : base(activityLength, date)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000;
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