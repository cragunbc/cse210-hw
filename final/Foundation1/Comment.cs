using System.Diagnostics.Contracts;

public class Comment
{
    public string _person;
    public string _text;


    public void Display()
    {
        Console.WriteLine($"Name: {_person}, Comment: {_text}");
    }
}