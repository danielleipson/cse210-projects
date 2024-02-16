public class ReflectingActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
    }

    public override void Start(int duration)
    {
        DisplayStartingMessage(duration);
        Console.WriteLine("Start reflecting...");
        ShowRandomPrompt();
        CountDown(duration);
        DisplayEndingMessage(duration);
    }

    private void ShowRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Length);
        Console.WriteLine(prompts[index]);
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
