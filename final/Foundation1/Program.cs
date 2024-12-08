using System;
using System.Collections.Generic;

namespace YouTubeVideoTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create videos
            Video video1 = new Video("Learning C#", "CodeMaster", 600);
            Video video2 = new Video("Cooking Pasta", "ChefGordon", 300);
            Video video3 = new Video("Travel Vlog: Italy", "Wanderer", 900);

            // Add comments to video1
            video1.AddComment(new Comment("Alice", "Great tutorial!"));
            video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
            video1.AddComment(new Comment("Charlie", "Can you make one on ASP.NET?"));

            // Add comments to video2
            video2.AddComment(new Comment("Diana", "This looks delicious!"));
            video2.AddComment(new Comment("Eve", "Can't wait to try this recipe!"));
            video2.AddComment(new Comment("Frank", "Nice tips on seasoning."));

            // Add comments to video3
            video3.AddComment(new Comment("George", "I love Italy!"));
            video3.AddComment(new Comment("Hannah", "Beautiful places."));
            video3.AddComment(new Comment("Ivan", "What a journey!"));

            // Add videos to a list
            List<Video> videos = new List<Video> { video1, video2, video3 };

            // Display video details
            foreach (var video in videos)
            {
                video.DisplayVideoDetails();
            }
        }
    }
}
