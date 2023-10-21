using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");

        Console.WriteLine("Welcome to the YouTube program! Your info is below:\n");

        Video v1 = new();
        v1._title = "Playing basketball with friends";
        v1._author = "Johnny Albert";
        v1._length = "200";
        v1.DisplayVideo();
        Console.WriteLine("");
        Comment c1 = new();
        c1._person = "Dave Smith";
        c1._text = "That's a really cool video! Thanks for sharing!";
        v1.AddComment(c1);
        Comment c2 = new();
        c2._person = "Jessica Johnson";
        c2._text = "Thanks for sharing! That's something that I really like to do with my friends as well!";
        v1.AddComment(c2);
        Comment c3 = new();
        c3._person = "Thomas Morris";
        c3._text = "We should play sometime. I bet that I could beat you in a 1v1";
        v1.AddComment(c3);
        v1.DisplayAll();
        Console.WriteLine("");

        Video v2 = new();
        v2._title = "Conclusion to how good the Utah Jazz will do this season";
        v2._author = "Ryan Ainge";
        v2._length = "1500";
        v2.DisplayVideo();
        Console.WriteLine("");
        Comment c4 = new();
        c4._person = "James Connor";
        c4._text = "I hope that they do well! I would love to see them in the playoffs this year";
        v2.AddComment(c4);
        Comment c5 = new();
        c5._person = "Ashley Olson";
        c5._text = "At this point I don't expect much because they disapoint us every year";
        v2.AddComment(c5);
        Comment c6 = new();
        c6._person = "Marty Tucker";
        c6._text = "Every year I get my hopes up and then they they don't go anywhere. Debating on chearing for a different team";
        v2.AddComment(c6);
        v2.DisplayAll();
        Console.WriteLine("");

        Video v3 = new();
        v3._author = "Nick Payne";
        v3._title = "How to code C# for beginners";
        v3._length = "2000";
        v3.DisplayVideo();
        Console.WriteLine("");
        Comment c7 = new();
        c7._person = "John Nelson";
        c7._text = "Thanks for making this video. This has been hard for me to learn and what you shared helped a lot!";
        v3.AddComment(c7);
        Comment c8 = new();
        c8._person = "Phil Davis";
        c8._text = "I thought that I knew everything, but it looks like there's still a lot that I need to learn. Thanks!";
        v3.AddComment(c8);
        Comment c9 = new();
        c9._person = "Dave O'Brien";
        c9._text = "Wow, this looks complicated. I'm going to have to look into how to do this more. Thanks for the intro.";
        v3.AddComment(c9);
        v3.DisplayAll();
    }
}