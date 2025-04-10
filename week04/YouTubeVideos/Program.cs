using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold all videos
        List<Video> videos = new List<Video>();

        // Create video 1
        Video video1 = new Video("Cat Compilation", "CatLover123", 325);
        video1.AddComment("Sarah", "These cats are so cute!");
        video1.AddComment("Mike", "I laughed so hard at 2:15");
        video1.AddComment("Jessica", "My cat does the same thing");

        // Create video 2
        Video video2 = new Video("Introduction to C#", "CodeMaster", 1200);
        video2.AddComment("Student01", "This really helped me understand abstraction");
        video2.AddComment("ProgrammingLearner", "Could you make a follow-up video on inheritance?");
        video2.AddComment("NewCoder", "I'm going to try this in my own project");
        video2.AddComment("Teacher", "I'm using this in my classroom, thanks!");

        // Create video 3
        Video video3 = new Video("Summer Hits", "MusicChannel", 240);
        video3.AddComment("MusicFan", "This song is amazing!");
        video3.AddComment("Guitarist", "Love the guitar solo at 1:45");
        video3.AddComment("DanceFan", "Great rhythm for dancing!");

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display all videos and their details
        Console.WriteLine("YouTube Video Tracking Program");
        Console.WriteLine("=============================\n");

        foreach (Video video in videos)
        {
            // Display video info
            Console.WriteLine(video.GetVideoInfo());
            
            // Display comments
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommentInfo()}");
            }
            Console.WriteLine(); // Add blank line between videos
        }
    }
}