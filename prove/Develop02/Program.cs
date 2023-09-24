//Websites used to help answer questions:
//https://stackoverflow.com/questions/1753508/how-could-i-get-a-random-string-from-a-list-and-assign-it-to-a-variable
using System;
using System.Globalization;
using System.Xml.Serialization;

class Program
{
    public static int choice;
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        //Entry anEntry = new Entry();
        PromptGenerator randomPrompt = new PromptGenerator();

        // Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine("Welcome to the journal program! Please follow the instructions below!");
        
        while (choice != 5)
        {
        Console.WriteLine("\nPlease select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        string userInput = Console.ReadLine();
        int choice = int.Parse(userInput);

            if (choice == 1)
            {
                Entry anEntry = new Entry();
                string randPrompt = randomPrompt.GetRandomPrompt();
                Console.Write(randPrompt);
                anEntry._promptText = randPrompt;
                anEntry._entryText = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                anEntry._date = dateText;

                theJournal.AddEntry(anEntry);
            }
            else if(choice == 2)
            {
                theJournal.DisplayAll();
            }
            else if(choice == 3)
            {
                Console.Write("What is the file that you want to look up? ");
                string file = Console.ReadLine();
                theJournal.LoadFromFile(file);
            }
            else if(choice == 4)
            {
                Console.Write("What is the file you want to save it as? ");
                string file = Console.ReadLine();
                theJournal.SaveToFile(file);
            }
            else if(choice == 5)
            {
                break;
            }
        }
    }
}