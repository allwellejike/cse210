using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        // Creating videos
        Video csharpTutorial = new Video("Learn C# in One Hour", "Programming Academy", 3600);
        Video oopLesson = new Video("OOP Concepts Explained", "Code Simplified", 1800);
        Video debuggingGuide = new Video("How to Debug C# Code", "Tech Tutorials", 1200);

        // Adding comments to videos
        csharpTutorial.AddComment(new Comment("Frank", "I have finally understood C#! Thanks!"));
        csharpTutorial.AddComment(new Comment("Sam", "This is literally the best explanation I've seen so far."));
        csharpTutorial.AddComment(new Comment("Clark", "I used to struggle with this, but now it makes sense."));

        oopLesson.AddComment(new Comment("Efe", "Indeed, Object-oriented programming is so useful!"));
        oopLesson.AddComment(new Comment("Sarah", "Can you do a video on design patterns?"));
        oopLesson.AddComment(new Comment("John", "Loved the examples! Very practical."));

        debuggingGuide.AddComment(new Comment("Ann", "Debugging is a lifesaver!"));
        debuggingGuide.AddComment(new Comment("Hannah", "This method saved me hours of work."));
        debuggingGuide.AddComment(new Comment("Ivory", "Finally, debugging makes sense. Thanks!!"));

        // Adding videos to the list
        videos.Add(csharpTutorial);
        videos.Add(oopLesson);
        videos.Add(debuggingGuide);

        // Displaying video details
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}
