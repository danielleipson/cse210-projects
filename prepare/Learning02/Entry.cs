public class Entry
{public DateTime Date { get; set; }
    public string Prompt { get; set; }
    public string Text { get; set; }

    public Entry(DateTime date, string prompt, string text)
    {
        Date = date;
        Prompt = prompt;
        Text = text;
    }

    public override string ToString()
    {
        return $"{Date} - Prompt: {Prompt}\n{Text}\n";
    }
}