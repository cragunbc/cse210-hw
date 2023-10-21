public class Video
{
    public string _title;
    public string _author;
    public string _length;

    public List<Comment> _comments = new();

    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nLength (In Seconds): {_length}");
    }

    public void DisplayAll()
    {
        foreach(Comment comment in _comments)
        {
            comment.Display();
        }

    }
}