using System;

class Program
{
    static void Main(string[] args)
    {        
        string text = "And it came to pass";
        string book = "test";
        string chapter = "1";
        string verse = "1";

        RandomScriptureGenerator rndScript = new();

        Reference reference = new Reference(book, chapter, verse);
        Scripture scripture = rndScript.GetRandomScripture();

        while (true)
        {
            Console.Clear();
            scripture.GetDisplayText();
            Console.Write("Press 'Enter' to continue or type 'quit' to finish: ");
            string userInput = Console.ReadLine();
            if (userInput == "quit")
            {
                break;
            }
            if(scripture.IsCompletelyHidden())
                break;
            scripture.HideRamdomWords(3);
        }


    }
}