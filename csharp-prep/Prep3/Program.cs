using System;
using System.CodeDom.Compiler;

class Program
{
    static void Main(string[] args)
    {
        //get number from user
        Console.Write("Enter a number between 1 and 100: ");
        string intput = Console.ReadLine();
        int number = int.Parse(intput);

        // generate random number between 1 and 100
        Random random = new Random();
        int rndMagicNumber = random.Next(1, 101);



        int guess = -1; //

        // loop until guess is correct
        while (guess != number)
        {

            // ask user for guess
            Console.Write("Guess a number between 1 and 100: ");
            string guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);

                // check if guess is correct
                if (guess < number)
                {
                    Console.WriteLine("Higher!");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Lower!");
                }
                else if (guess == number)
                {
                    Console.WriteLine("You got it!");
                }


            

            



        }
        
    }
}