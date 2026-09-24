using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("C#", "Microsoft", 180);

        Comment comment1 = new Comment("Katia", "I understood everything; it was very clear.");
        video1.AddComment(comment1);

        Comment comment2 = new Comment("Sebastian", "Wow! I want to learn more.");
        video1.AddComment(comment2);

        Comment comment3 = new Comment("Michelle", "I loved it!");
        video1.AddComment(comment3);

        Comment comment4 = new Comment("Jin", "I'm really smart after watching this video.");
        video1.AddComment(comment4);


        Video video2 = new Video("Authentic Mexican Tacos", "Mexican Style", 900);

        Comment comment5 = new Comment("Lizbeth", "It looks delicious.");
        video2.AddComment(comment5);

        Comment comment6 = new Comment("Jimin", "Finally! The real recipe for Mexican tacos.");
        video2.AddComment(comment6);

        Comment comment7 = new Comment("Jay", "I need to go get tacos right now!");
        video2.AddComment(comment7);

        
        Video video3 = new Video("Tutorial: How to Dance the Macarena", "DanceDance", 300);

        Comment comment8 = new Comment("Jake", "Why is it so difficult to learn?");
        video3.AddComment(comment8);

        Comment comment9 = new Comment("Ian", "I'm so good at dancing this!");
        video3.AddComment(comment9);

        Comment comment10 = new Comment("Angela", "Oh, yeah, this is exactly what I'm talking about.");
        video3.AddComment(comment10);


        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetDisplayText());
        }
    }
}