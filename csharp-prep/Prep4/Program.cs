using System;
using System.Collections.Generic;
using System.Linq; // Good practice to include this for Max() function, I gues

class Program
{
    static void Main(string[] args)
    {
        //Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a series of numbers (enter 0 to stop).");
        Console.Write("Enter a number: ");
        do
        {
            int number = int.Parse(Console.ReadLine()); 
            if (number == 0) break; // Stop if user enters 0 before added to list
            numbers.Add(number); // Add the number to the list
            Console.Write("Enter a number: ");
        } while (true);
              

        // compute the sum, or total, of the numbers in the list
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number; // Add each number to the sum
        }

        // compute the average of the numbers in the list
        double avg = (double)sum / numbers.Count;

        int max = numbers.Max(); // Find the maximum number in the list
        
        //print the sum, average, and max values of the list
        Console.WriteLine($"The sum of the numbers is: {sum}"); 
        Console.WriteLine($"The average of the numbers is: {avg}");
        Console.WriteLine($"The largest number is: {max}");
    }
}