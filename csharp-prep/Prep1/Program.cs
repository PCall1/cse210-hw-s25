using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        // Prompt the user for their first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        //Prompt the user for their last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine(); //enter a line for formatting

        // Display the user's name in the 007 format "lastName, firstName lastName"
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}