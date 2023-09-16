using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        int number = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        float count = 0;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string userNumber = Console.ReadLine();
            number = int.Parse(userNumber);
            if (number != 0)
            {
            numbers.Add(number);
            count += 1;
            }
        }
        float sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        float average = sum / count;
        Console.WriteLine($"The average is {average}");

        int largest = numbers.Max();
        Console.WriteLine($"the largest number is: {largest}");
    }
}