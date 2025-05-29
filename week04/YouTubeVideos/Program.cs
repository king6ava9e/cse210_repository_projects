using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Create a new video
        Videos video = new Videos("Learning C#", "John Doe", 300);

        // Add comments to the video
        video.AddComment(new Comment("Alice", "Great video!"));
        video.AddComment(new Comment("Bob", "Very informative, thanks!"));
        video.AddComment(new Comment("Charlie", "I learned a lot from this."));
        video.AddComment(new Comment("Diana", "Can't wait for the next one!"));

        //creating another video
        Videos video2 = new Videos("Advanced C# Techniques", "Jane Smith", 600);
        // Add comments to the second video
        video2.AddComment(new Comment("Eve", "This is exactly what I needed!"));
        video2.AddComment(new Comment("Frank", "Excellent explanation!"));
        video2.AddComment(new Comment("Grace", "I love the examples you provided."));
        video2.AddComment(new Comment("Hank", "Looking forward to more content like this."));

        // creating a third video
        Videos video3 = new Videos("C# Best Practices", "Alice Johnson", 450);
        // Add comments to the third video
        video3.AddComment(new Comment("Ivy", "This is very helpful, thank you!"));
        video3.AddComment(new Comment("Jack", "I appreciate the tips shared in this video."));
        video3.AddComment(new Comment("Kathy", "Great insights, I will apply these in my projects."));
        video3.AddComment(new Comment("Leo", "Fantastic video, very well explained!"));

        // store videos in a list
        List<Videos> videosList = new List<Videos> { video, video2, video3 };
        // Display the number of comments for each video
        foreach (var vid in videosList)
        {
            Console.WriteLine($"Video Title: {vid._Title}");
            Console.WriteLine($"Author: {vid._Author}");
            Console.WriteLine($"Length: {vid._Length} seconds");
            Console.WriteLine($"Number of Comments: {vid.GetNumberOfComments()}");
            Console.WriteLine();
        }

    }
}