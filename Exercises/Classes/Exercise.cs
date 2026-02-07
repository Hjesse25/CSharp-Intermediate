using System;

namespace Classes;

public class Exercise
{
    public static void Exercise1()
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }

        stopwatch.Stop();

        var duration = stopwatch.GetInterval();
        Console.WriteLine($"Duration: {duration}");
    }

    public static void Exercise2()
    {
        var post = new Post
        {
            Title = "I got error code CS307",
            Description = "Insert a long description of the post here..."
        };

        post.UpVote();
        post.UpVote();
        post.UpVote();
        post.UpVote();
        post.UpVote();
        post.DownVote();
        post.DownVote();
        post.UpVote();
        post.UpVote();
        post.DownVote();
        post.UpVote();
        post.UpVote();
        post.UpVote();

        post.DisplayInfo();
    }
}
