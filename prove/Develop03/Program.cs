using System;

class Program
{
    public static void Main(string[] args)
    {
        
        var reference = new Reference("2 Nephi", 9, 28, 29);
        var scripture = new Scripture(reference, "O that cunning plan of the evil one! O the vainness, and the frailties, and the foolishness of men! When they are learned they think they are wise, and they hearken not unto the counsel of God, for they set it aside, supposing they know of themselves, wherefore, their wisdom is foolishness and it profiteth them not. And they shall perish. But to be learned is good if they hearken unto the counsels of God.");

        
        Console.WriteLine("Scripture Reference: " + scripture.Reference);
        Console.WriteLine("Press Enter to reveal a hidden word or type 'quit' to exit.");
        scripture.Display();

        
        while (!scripture.AllWordsHidden && Console.ReadLine().ToLower() != "quit")
        {
            scripture.HideRandomWord();
            scripture.Display();
        }
    }
}
