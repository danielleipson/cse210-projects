public class ListeningActivity : Activity
{
    public ListeningActivity() : base("Listening", "This activity will help you improve your listening skills by focusing on auditory stimuli.")
    {
    }

    public override void Start(int duration)
    {
        DisplayStartingMessage(duration);
        Console.WriteLine("Start listening...");
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
