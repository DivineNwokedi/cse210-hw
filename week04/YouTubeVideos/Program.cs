
class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Video 1", "Author 1", 10);
        video1.AddComment(new Comment("Commenter 1", "Great video!"));
        video1.AddComment(new Comment("Commenter 2", "Love it!"));
        video1.AddComment(new Comment("Commenter 3", "Well done!"));

        Video video2 = new Video("Video 2", "Author 2", 20);
        video2.AddComment(new Comment("Commenter 4", "Excellent!"));
        video2.AddComment(new Comment("Commenter 5", "Informative!"));
        video2.AddComment(new Comment("Commenter 6", "Engaging!"));

        Video video3 = new Video("Video 3", "Author 3", 30);
        video3.AddComment(new Comment("Commenter 7", "Good job!"));
        video3.AddComment(new Comment("Commenter 8", "Well explained!"));
        video3.AddComment(new Comment("Commenter 9", "Thanks for sharing!"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetDisplayString());
            Console.WriteLine();
        }
    }
}



