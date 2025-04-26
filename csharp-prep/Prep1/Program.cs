using System;
using System.Threading;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        // Prompt the user for their first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Add a delay in milliseconds
        Thread.Sleep(500);

        //Prompt the user for their last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

            Console.WriteLine(); //enter a line for formatting
            Thread.Sleep(1500);

        // Display the user's name in the 007 format "lastName, firstName lastName"
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

            Console.WriteLine(); //enter a line for formatting

    }
}