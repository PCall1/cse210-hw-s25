using System;

class Program
{
    static void Main(string[] args)
    {
        // Calculate letter grades based on percentage

        // Prompt the user for their percentage
        Console.WriteLine("Welcome to the letter grade calculator!");
        Console.Write("Please enter your percentage (00.00) to see your letter grade. ");
        float pg = float.Parse(Console.ReadLine()); // Percent grade (pg) variable
        string lg;// Letter grade (lg) variable
        float ec; // Extra credit (ec) variable

        // Determine the letter grade based on the percentage
        if (pg >= 90)
        {
            lg = "A";
        }
        else if (pg >= 80 && pg < 90)
        {
            lg = "B";
        }
        else if (pg >= 70 && pg < 80)
        {
            lg = "C";
        }
        else if (pg >= 60 && pg < 70)
        {
            lg = "D";
        }
        else if (pg < 60 && pg >= 0)
        {
            lg = "F";
        }
        else
        {
            lg = "_error"; // Set to error if percentage is invalid
        }

        // calculate letter grade sign
        string lgs;
        if (lg == "A" && pg <= 93 || lg == "B" || lg == "C" || lg == "D")
        {
            if (pg % 10 >= 7) // pg % 10, divides pg by 10 and returns the remainder
            {
                lgs = "+"; // Add a plus sign for 7 <= lg <= 10
            }
            else if (pg % 10 <= 3) // Add a minus sign for 0 <= lg <= 3
            {
                lgs = "-";
            }
            else
            {
                lgs = ""; // No sign for 3 < lg < 7
            }
        }
        else
        {
            lgs = ""; // No sign for F or error
        }

        //print the letter grade
        Console.WriteLine($"Your letter grade is {lg}{lgs}.");

        // Check if user passed class
        if (pg >= 70 && pg <= 100)
        {
            Console.WriteLine("Congratulations, you passed the class!");
        }
        else if (pg > 100)// Extra credit calculation for percentages over 100
        {
            ec = pg - 100; 
            Console.WriteLine("Congratulations, you passed the class!");
            Console.WriteLine($"You also earned {ec} points of extra credit.");
        }
        else if (pg < 70 && pg >= 0)
        {
            Console.WriteLine("You must have at least 70%(C) to pass the class.");
        }
        else
        {
            Console.WriteLine("Invalid percentage entered. Please enter a number between 0 and 100.");
        }
    }
}