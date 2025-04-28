using System;
using System.CodeDom.Compiler;

class Program
{
    static void Main(string[] args)
    {
        /*
        //get number from user
        Console.Write("Enter a number between 1 and 100: ");
        string intput = Console.ReadLine();
        int number = int.Parse(intput);
        */


        // generate random number between 1 and 100
        Random random = new Random();
        int rndMagicNumber = random.Next(1, 101);



        int guess = -1; // default out of range
        Console.Write("Guess a number between 1 and 100: "); // ask user for guess
        int guesses = 0;


        // loop until guess is correct
        while (guess != rndMagicNumber)
        {
            
            // accept guess from user
            string guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);

                // check if guess is correct
                if (guess < rndMagicNumber)
                {
                    Console.Write("Higher! \nGuess again: ");
                }
                else if (guess > rndMagicNumber)
                {
                    Console.Write("Lower! \nGuess again: ");
                }
                else if (guess == rndMagicNumber)
                {
                    Console.WriteLine("You got it!");
                }
            guesses++;
        }
        Console.WriteLine($"It took you {guesses} guesses!"); // print number of guesses, stretch challenge
    }
}