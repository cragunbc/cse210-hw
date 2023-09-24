//Websites used to help answer questions:
//https://stackoverflow.com/questions/1753508/how-could-i-get-a-random-string-from-a-list-and-assign-it-to-a-variable
public class PromptGenerator
{
    public List<string> _prompts = new List<string>();


    public string GetRandomPrompt()
    {
        _prompts.Add("Who was the most interesting person I intereacted with today? ");
        _prompts.Add("What was the best part of my day? ");
        _prompts.Add("How did I see the hand of the Lord in my life today? ");
        _prompts.Add("What was the strongest emotion I felt today? ");
        _prompts.Add("If I had one thing I could do over today, what would it be? ");
        _prompts.Add("What was one thing that you're glad you did today? ");
        _prompts.Add("After reflecting on your day, what's one thing you can do better tomorrow? ");
        
        Random prompt = new Random();
        int index = prompt.Next(_prompts.Count());
        string randomString = _prompts[index];

        return randomString;
    }

}