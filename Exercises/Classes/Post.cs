namespace Classes;

public class Post
{
    public required string Title { get; set; }
    public required string Description { get; set; }
    public DateTime CreatedAt { get; private set; } = DateTime.Now;
    private int _votes;

    public void UpVote()
    {
        _votes += 1;
    }

    public void DownVote()
    {
        _votes -= 1;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"CreatedAt: {CreatedAt}");
        Console.WriteLine($"Votes: {_votes}");
    }
}
