using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUsername();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResults(userName, squaredNumber);            
        // Console.WriteLine("Hello Prep5 World!");
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUsername()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string number = Console.ReadLine();
            int num = int.Parse(number);

            return num;
        }
        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }
        static void DisplayResults(string name, int square)
        {
            Console.Write($"{name}, the square of your number is {square}");
        }
    }
}