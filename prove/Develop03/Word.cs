class Word
{
    public string Text { get; }
    public bool Hidden { get; set; }

    public Word(string text)
    {
        Text = text;
        Hidden = false;
    }

    public override string ToString()
    {
        return Hidden ?  new string('_', Text.Length) : Text;
    }
}