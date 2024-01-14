using System;

class Program
{
    static void Main(string[] args)
    {
       //Console.Write("what is the magin number? ");
       //int magicNumber = int.Parse(Console.ReadLine());


      do
      { 
        PlayGame ();
        Console.Write ("Do you want to play again? (Y/N): ");
      }while (Console.ReadLine().ToLower() == "y");
      Console.WriteLine ("Thanks for playing!");
    }

      static void PlayGame()
      {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);
        int userguess;
        int guesses = 0;
        
        Console.WriteLine("Guess the number between 1 and 100");

        do
        {
            Console.Write("What is your guess? ");
            userguess = int.Parse(Console.ReadLine());
            guesses++;
        

            if (magicNumber > userguess)
            {
                Console.WriteLine ("Higher");
            }
            else if (magicNumber < userguess)
            {
                Console.WriteLine ("Lower");
            }
            else
            {
                Console.WriteLine ($"You guessed it!");
                Console.WriteLine ($"You have guessed {guesses} times.");
            } 
        } while (userguess != magicNumber);
      }
}