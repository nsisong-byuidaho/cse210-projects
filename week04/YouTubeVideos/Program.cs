using System;
using System.Collections.Generic;
// In order to exceed requirement, I added a code for the user to input in order to reply comments and also,
// method to add replies in the comment class.
class Program
{
   static void Main()
    {
        Video video1 = new Video("Abstraction in C#", "CodeTutors", 700);
        Video video2 = new Video("Logical Operators", "ProgrammingWithOkoli", 1000);
        Video video3 = new Video("C# File Naming", "TechWithBrown", 850);

        video1.AddComment(new Comment("Peace", "Great introduction to Abstraction#!"));
        video1.AddComment(new Comment("Lycia", "Very clear explanation."));
        video1.AddComment(new Comment("Anne", "Looking forward to more videos!"));

        video2.AddComment(new Comment("Amos", "Logical operators finally makes sense, thanks!"));
        video2.AddComment(new Comment("Emem", "A wonderful knowlegde on logical operators."));
        video2.AddComment(new Comment("Oty", "What are the 8 opeators in python?"));

        video3.AddComment(new Comment("Ini", "This is just what I needed!"));
        video3.AddComment(new Comment("Edidiong", "Very useful for my project."));
        video3.AddComment(new Comment("Inem", "Could you explain styling in more detail?"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Commenter}: {comment.Text}");
            }
            Console.WriteLine(new string('-', 50)); 
        }
    }
}
