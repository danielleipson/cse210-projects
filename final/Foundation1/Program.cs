class Program
{
    static void Main(string[] args)
    {
        // Create video instances
        var video1 = new Video("Introduction to Watercolor", "Ilena May", 120);
        var video2 = new Video("How to paint an owl using acrylic", "Ashley Gallagher", 180);

        // Add comments to the videos
        video1.AddComment(new Comment("Charice", "You have wonderful technique!"));
        video1.AddComment(new Comment("Juan", "Very mesmorizing."));
        video2.AddComment(new Comment("Charlotte", "There are a lot of different types of brush strokes needed to make that owl. I love its bright yellow eyes!"));

        // Display video details
        Console.WriteLine("Video 1 Details:");
        video1.DisplayDetails();
        Console.WriteLine("-------------------");
        Console.WriteLine("Video 2 Details:");
        video2.DisplayDetails();
    }
}