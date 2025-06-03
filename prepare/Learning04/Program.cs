using System;

class Program
{
    static void Main(string[] args)
    {
        string topic = "Laplace Transforms";
        string studentName = "John Doe";
        string selection = "Chapter 1";
        string problemNumbers = "1, 2, 3, 4";
        string essayTitle = "The Causes of World War II";


        Assignment assignment1 = new Assignment(studentName, topic);
        Console.WriteLine($"{assignment1.GetSummary()}");

        MathAssignment assignment2 = new MathAssignment(studentName, topic, selection, problemNumbers);
        Console.WriteLine();
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment(studentName, topic, essayTitle);
        Console.WriteLine();
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInfo());

    }
}