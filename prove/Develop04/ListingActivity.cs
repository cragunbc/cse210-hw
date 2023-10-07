public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new()
    {"Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"};
    // Random rnd
    private Random rnd = new();
    public ListingActivity()
    {
        // set name and description
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        // List as many items as you can based on the following prompt
        Console.WriteLine("List as many responses you can to the following prompt:");
        // display random prompt
        Console.WriteLine(GetRandomPrompt());
        DateTime end = DateTime.Now.AddSeconds(_duration);
        while(DateTime.Now < end)
        {
            string input = Console.ReadLine();
            _count++;
        }
        Console.Write($"You listed {_count} answers!");
        ShowSpinner(3);
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        // get random index
        int index = rnd.Next(_prompts.Count());
        
        // return prompt at index
        return _prompts[index];
    }
}