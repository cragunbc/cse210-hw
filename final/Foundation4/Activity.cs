public abstract class Activity
{
    protected string _date;
    protected double _activityLength;

    public Activity(double activityLength, string date)
    {
        _activityLength = activityLength;
        _date = date;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date} {GetType()} ({_activityLength} min):\nDistance: {Math.Round(GetDistance(), 2)} km\nSpeed: {Math.Round(GetSpeed(), 2)} kph\nPace: {Math.Round(GetPace(), 2)} min per km";
    }
}