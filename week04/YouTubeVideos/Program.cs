using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("How to Bake Bread", "Chef John", 300);
        video1.AddComment("Jane", "Great recipe! I love baking bread.");
        video1.AddComment("Mike", "Thanks for the tips, Chef John!");
        video1.AddComment("Alice", "Can't wait to try this recipe!");
        video1.AddComment("Bob", "I made this bread and it turned out amazing!");
        videos.Add(video1);

        Video video2 = new Video("The Best Banana Bread Recipe", "Baking with Sonia", 240);
        video2.AddComment("Tom", "This banana bread is delicious!");
        video2.AddComment("Lucy", "I added walnuts and it was perfect!");
        video2.AddComment("Emma", "Thanks for sharing this recipe!");
        video2.AddComment("Liam", "I love banana bread, can't wait to try this!");
        videos.Add(video2);

        Video video3 = new Video("Chocolate Chip Cookies", "Cookie Master", 180);
        video3.AddComment("Olivia", "These cookies are the best!");
        video3.AddComment("Noah", "I made these for my family and they loved them!");
        video3.AddComment("Sophia", "I added extra chocolate chips, so good!");
        video3.AddComment("James", "Thanks for the recipe, Cookie Master!");
        videos.Add(video3);

        Video video4 = new Video("Pasta Carbonara", "Italian Chef Marco", 360);
        video4.AddComment("Isabella", "This pasta is so creamy and delicious!");
        video4.AddComment("Ethan", "I love Italian food, can't wait to try this recipe!");
        video4.AddComment("Mia", "Thanks for the easy recipe, Chef Marco!");
        video4.AddComment("Alexander", "I made this for dinner and it was a hit!");
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    } 

    
}