using System;

class Program
{
    static void Main(string[] args)
    {
        // call several functions in main
        DisplayWelcome();

        string userName = PromptUserName(); //almost forgot to assign the return value to a variable

        int userNumber = PromptUserNumber();

        int nmSqr = SquareUserNumber(userNumber);

        DisplayMessage(userName, nmSqr);

    }

    //displays program welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    //prompts user for name, and returns it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    //asks for users id number and returns it
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }

    //squares the users number and returns it
    static int SquareUserNumber(int userNumber)
    {
        int nmSqr = userNumber * userNumber;
        return nmSqr;
    }

    // displays a message with the users name and number squared
    static void DisplayMessage(string userName, int nmSqr)
    {
        Console.WriteLine();
        Console.WriteLine($"Hello {userName}. Your favorite number squared is {nmSqr}.");
        Console.WriteLine("Have a great day!");
        Console.WriteLine();
    }
}