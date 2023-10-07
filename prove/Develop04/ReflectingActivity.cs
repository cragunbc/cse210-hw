public class ReflectingActivity : Activity
{
    private List<string> _prompts = new()
    {"Think of a time when you stood up for someone else",
    "Think of a time when you did something really difficult",
    "Think of a time when you helped someone in need",
    "Think of a time when you did something truly selfless"};
    private List<string> _questions = new()
    {"Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"};
    // Random rnd
    private Random rnd = new Random();
    private List<int> usedIndexes = new();


    public ReflectingActivity()
    {
        // set name and description
        _name = "Reflecting";
        _description = "This activity will help you reflect on time in your life when " + 
        "you have shown strength and resilience. This will help you recognize the power you " + 
        "and how you can use it in other aspects of your life.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Consider the following prompt:\n");
        // Display the prompt
        Console.WriteLine(GetRandomPrompt());
        // ask user to hit enter to continue
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        string userInput = Console.ReadLine();
        DateTime end = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < end)
        {
            Console.WriteLine(GetRandomQuestion());
            // get random question
            // display spinner for 10 seconds
            ShowSpinner(10);
        }
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        // get random index
        int index = rnd.Next(_prompts.Count());
        // return prompt at index
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        // get random index
        int index;
        do
        {
            index = rnd.Next(_questions.Count());
        }while(usedIndexes.Contains(index));
        
        usedIndexes.Add(index);
        if(usedIndexes.Count == _questions.Count)
            usedIndexes.Clear();
        // return prompt at index
        return _questions[index];
    }
}