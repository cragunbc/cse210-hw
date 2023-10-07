public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing. This activity runs in 10 second intervals.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        DateTime end = DateTime.Now.AddSeconds(_duration);
        while(DateTime.Now < end)
        {
            Console.Write("\n\nBreathe in...");
            ShowCountDown(5);
            Console.Write("\n\nNow breathe out...");
            ShowCountDown(5);
        }
        DisplayEndingMessage();
    }
}