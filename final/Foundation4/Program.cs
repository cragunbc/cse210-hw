using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new();
        Bicyle b1 = new(40, DateTime.Now.ToShortDateString(), 10);
        activities.Add(b1);

        Running r1 = new(60, DateTime.Now.ToShortDateString(), 2000);
        activities.Add(r1);

        Swimming s1 = new(30, DateTime.Now.ToShortDateString(), 20);
        activities.Add(s1);

        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary() + "\n");
        }
    }
}