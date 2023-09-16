using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");

        // Console.Write("What is the magic number? ");
        // string magicNumber = Console.ReadLine();
        // int number = int.Parse(magicNumber);

        Random randomNumber = new Random();
        int number = randomNumber.Next(1, 100);
        
        int guess = -1;

        while (guess != number)
        {
        Console.Write("What is your guess? ");
        guess = int.Parse(Console.ReadLine());
            if (guess < number)
            {
            Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
            Console.WriteLine("Lower");
            }
            else
            {
            Console.WriteLine("You guessed it!");
            }
        }
        
    }
}