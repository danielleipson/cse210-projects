class Scripture
{
    public Reference Reference { get; }
    public List<Word> Words { get; }

    public bool AllWordsHidden => Words.All(w => w.Hidden);

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(w => new Word(w)).ToList();
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine($"Scripture: {Reference}\n");

        foreach (var word in Words)
        {
            Console.Write($"{word} ");
        }

        Console.WriteLine("\n");
    }

    public void HideRandomWord()
    {
        Random rand = new Random();
        int index;
        do
        {
            index = rand.Next(Words.Count);
        } while (Words[index].Hidden);

        Words[index].Hidden = true;
    }
}