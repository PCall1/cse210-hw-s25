using System;
using System.Net.NetworkInformation;

class Program
{
    static int totalPoints = 0;
    static List<Goal> goalList = new List<Goal>();
    static List<string> loadedFiles = [];

    static void Main(string[] args)
    {
        int choice = 0;
        while (choice != 6)
        {
            DisplayMenu();
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Create a new goal
                    Console.WriteLine();
                    Console.WriteLine("1) Simple Goal");
                    Console.WriteLine("2) Eternal Goal");
                    Console.WriteLine("3) Checklist Goal");
                    Console.Write("What type of Goal would you like to create: ");
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            // Create a Simple Goal
                            Console.WriteLine("Simple Goal:");
                            Console.Write("Enter the name of the goal: ");
                            string simpleName = Console.ReadLine();
                            Console.Write("Enter the description of the goal: ");
                            string simpleDescription = Console.ReadLine();
                            Console.Write("Enter the reward value for the goal: ");
                            int simpleRewardValue = int.Parse(Console.ReadLine());
                            // Add logic to create and store the Simple Goal
                            Simple simpleGoal = new Simple(simpleName, simpleDescription, simpleRewardValue);
                            goalList.Add(simpleGoal);

                            break;
                        case 2:
                            // Create an Eternal Goal
                            Console.WriteLine("Eternal Goal:");
                            Console.Write("Enter the name of the goal: ");
                            string eternalName = Console.ReadLine();
                            Console.Write("Enter the description of the goal: ");
                            string eternalDescription = Console.ReadLine();
                            Console.Write("Enter the reward value for the goal: ");
                            int eternalRewardValue = int.Parse(Console.ReadLine());
                            // Add logic to create and store the Eternal Goal
                            Eternal eternalGoal = new Eternal(eternalName, eternalDescription,
                            eternalRewardValue);

                            goalList.Add(eternalGoal);

                            break;
                        case 3:
                            // Create a Checklist Goal
                            Console.WriteLine("Checklist Goal:");
                            Console.Write("Enter the name of the goal: ");
                            string checklistName = Console.ReadLine();
                            Console.Write("Enter the description of the goal: ");
                            string checklistDescription = Console.ReadLine();
                            Console.Write("Enter the REWARD value for each completion: ");
                            int checklistRewardValue = int.Parse(Console.ReadLine());
                            Console.Write("Enter the BONUS point value for when all are completed: ");
                            int checklistBonusPoints = int.Parse(Console.ReadLine());
                            Console.Write("Enter the number of times you'd like to complete this goal: ");
                            int checklistIterations = int.Parse(Console.ReadLine());
                            // Add logic to create and store the Checklist Goal
                            Checklist checklistGoal = new Checklist(checklistBonusPoints,
                            checklistIterations, checklistName, checklistDescription,
                            checklistRewardValue);

                            goalList.Add(checklistGoal);

                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }



                    break;
                case 2:
                    // List goals
                    ListGoals();
                    break;
                case 3:
                    // Record an event
                    ListGoals();
                    Console.Write("What goal would you like to record: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    totalPoints += goalList[index].RecordEvent();

                    break;
                case 4:
                    // Save goals
                    Console.WriteLine("Saving goals...");
                    // Add logic to save goals
                    SaveGoal();
                    break;
                case 5:
                    // Load goals
                    Console.WriteLine("Loading goals...");
                    // Add logic to load goals
                    LoadGoal();
                    break;
                case 6:
                    Console.WriteLine("Exiting the program.");
                    Environment.Exit(0);
                    return; // Exit the program


                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {totalPoints} points.");
        Console.WriteLine();
        Console.WriteLine("Welcome to the Goal Tracker!");
        Console.WriteLine("1. Create a new goal");
        Console.WriteLine("2. List goals");
        Console.WriteLine("3. Record an event");
        Console.WriteLine("4. Save goals");
        Console.WriteLine("5. Load goals");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    static void ListGoals()
    {
        Console.WriteLine();
        for (int i = 0; i < goalList.Count; i++)
        {
            Console.Write($"{i + 1}) ");
            goalList[i].Display();
        }
    }

    static void SaveGoal()
    {
        string fileName;
        Console.WriteLine("Enter the filename to save to (myFile.txt):");
        fileName = Console.ReadLine();
        if (!Directory.Exists("GoalFolder"))
        {
            Directory.CreateDirectory("GoalFolder");
        }

        using (StreamWriter writer = new StreamWriter("GoalFolder/" + fileName))
        {
            writer.WriteLine(totalPoints);
            foreach (Goal entry in goalList)
            {
                List<string> goalData = entry.SaveInfo();
                writer.WriteLine(string.Join("=|", goalData)); // change separator as needed
            }
        }
        Console.WriteLine("Goal saved successfully.");
    }

    static void LoadGoal()
    {
        string fileName;
        Console.WriteLine("Enter the filename to load:");
        fileName = Console.ReadLine();
        if (loadedFiles.Contains(fileName))
            return;
        loadedFiles.Add(fileName);
        if (File.Exists("GoalFolder/" + fileName))
        {
            string[] lines = File.ReadAllLines("GoalFolder/" + fileName);
            totalPoints += int.Parse(lines[0]);
            foreach (string line in lines.Skip(1))
            {
                string[] goalData = line.Split("=|"); // change separator as needed
                string goalType = goalData[0];

                switch (goalType)
                {
                    case "Simple Goal":
                        Simple simplegoal = new Simple(goalData[1], goalData[2], int.Parse(goalData[3]), bool.Parse(goalData[4]));
                        goalList.Add(simplegoal);
                        break;
                    case "Eternal Goal":
                        Eternal eternalGoal = new Eternal(goalData[1], goalData[2], int.Parse(goalData[3]));
                        goalList.Add(eternalGoal);
                        break;
                    case "Checklist Goal":
                        Checklist checklist = new Checklist(int.Parse(goalData[7]), int.Parse(goalData[6]),
                        goalData[1], goalData[2], int.Parse(goalData[3]), bool.Parse(goalData[4]), int.Parse(goalData[5]));
                        goalList.Add(checklist);
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("***File not found.\n");
        }
    }
}