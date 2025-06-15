using System;

class Program
{
    static void Main(string[] args)
    {
        string choice;
        do
        {
            DisplayMenu();
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    // Call Breathing Activity
                    int duration = GetDuration();
                    Breathing breathingActivity = new Breathing(duration);
                    breathingActivity.DisplayStartMessage();
                    breathingActivity.PauseAnimation(5, 1);
                    breathingActivity.DoForDuration(breathingActivity.Display, duration);
                    breathingActivity.DisplayEndMessage();
                    breathingActivity.PauseAnimation(5, 0);

                    break;

                case "2":
                    // Call Reflection Activity
                    int duration2 = GetDuration();
                    Reflection reflection = new Reflection(duration2);
                    reflection.DisplayStartMessage();
                    reflection.PauseAnimation(10, 0);
                    reflection.DoForDuration(reflection.Display, duration2);
                    reflection.DisplayEndMessage();
                    reflection.PauseAnimation(5, 0);

                    break;

                case "3":
                    // Call Listing Activity
                    int duration3 = GetDuration();
                    Listing list = new Listing(duration3);
                    list.DisplayStartMessage();
                    list.Display();
                    list.PauseAnimation(10, 0);
                    list.DoForDuration(list.GetResponse, duration3);
                    Console.WriteLine(list.GetEndCount());
                    list.DisplayEndMessage();

                    break;

                case "4":
                    Console.WriteLine("Exiting...");

                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");

                    break;
            }
        } while (choice != "4");

    }

    static void DisplayMenu()
    {
        Console.WriteLine("Welcome to the Program!");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Exit");
        Console.Write("What do you want to do?: ");
    }

    static int GetDuration()
    {
        Console.WriteLine("How long would you like to do it for? (in seconds)");
        string durationS = Console.ReadLine();
        int duration = int.Parse(durationS);
        return duration;
    }
}


/// This may not qualify for the stretch, but I used a different method to 
/// run each child class from the parent class with the DoForDuration method, 
/// This was a stretch at least for me. I did it because I wanted to stick 
/// with what I thought fit more the idea of inheritance, since each child 
/// would need some form of the same function so I moved it to the parent class.
