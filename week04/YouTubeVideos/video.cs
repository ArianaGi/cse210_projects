using System.Transactions;

class Video
{
    private string _author;
    private string _title;
    private int _lengthInSeconds;
    private List<Comment> _comments = new List<Comment>();

    public Video(string author, string title, int lengthInSeconds)
    {
        _author = author;
        _title = title;
        _lengthInSeconds = lengthInSeconds;
    }

    public void AddComment(string name, string content)
    {
        Comment comment = new Comment(name, content);
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Length: {_lengthInSeconds} secnds");
        Console.WriteLine($"Number of comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"- {comment.GetCommentDisplay()}");
        }

        Console.WriteLine();
    }

}