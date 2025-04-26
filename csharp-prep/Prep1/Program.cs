using System;
using System.Threading;


class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep1 World!"); // This line is not needed for the task

        // Prompt the user for their first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Add a delay in milliseconds
        Thread.Sleep(700);

        //Prompt the user for their last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

            Console.WriteLine(); //enter a line for formatting
            Thread.Sleep(1500); //1.5 second delay 

        // Display the user's name in the 007 format "lastName, firstName lastName"
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

            Console.WriteLine(); //enter a line for formatting

    }
}