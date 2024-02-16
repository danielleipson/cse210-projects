public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void Start(int duration)
    {
        DisplayStartingMessage(duration);
        Console.WriteLine("Begin breathing...");
        CountDown(duration);
        DisplayEndingMessage(duration);
    }

    private void CountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Remaining time: {i} seconds");
            Thread.Sleep(3000); 
        }
    }
}
