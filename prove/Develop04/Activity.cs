public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    private List<char> _spinner = new(){'|', '/', '\\', '-'};

  
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} activity" +
            $"\n\n{_description}" +
            "\n\nHow long, in seconds, would you like for your session?");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.Write("Get ready...");
        ShowSpinner(5);
        Console.Clear();
    }

    public void DisplayEndingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Well done! You have completed {_duration} seconds of the {_name} activity");
        ShowSpinner(5);
        Console.Clear();

    }

    public void ShowSpinner(int seconds)
    {
        while (seconds > 0)
        {
            foreach (char i in _spinner)
            {
                Console.Write(i);
                Thread.Sleep(250);
                Console.Write($"\b \b");
            }
            seconds--;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write($"\b \b");
        }
    }

}