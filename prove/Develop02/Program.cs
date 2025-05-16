using System;
using System.Xml.Serialization;
using Microsoft.VisualBasic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Thoughts of Sorts");
        
        Menu();

        /* Stretch 
        I added a feature to create a JournalFolder to save the journal
        entries into. The program first checks if the folder exists,
        then creates it if it doesn't.

        I also added an option to delete a file. This can be risky so I
        added a confirmation prompt to the user so they can confirm 
        deletion.
        */

    }


    static void Menu() {
        Journal journal = new();
        int choice = 0;
        while (choice != 5) {
            Console.WriteLine("What would you like to do ?");
            Console.WriteLine("1. Add a new entry");
            Console.WriteLine("2. View all entries");
            Console.WriteLine("3. Load previous entry.");
            Console.WriteLine("4. Save entry to Jounral.");
            Console.WriteLine("5. Exit");
            Console.WriteLine("6. Delete file");
            choice = int.Parse(Console.ReadLine());
            

            switch (choice) {
                case 1:
                    Entry newEntry = new();
                    newEntry.RandomPrompt();
                    newEntry.GetResponse();
                    journal.AddEntry(newEntry);
                    break;
                case 2:
                    // View all entries
                    journal.DisplayJournal();
                    break;
                case 3:
                    // Load saved journal
                    journal.LoadJournalFromFile();
                    break;
                case 4:
                    // Save entry to Journal
                    journal.SaveJournalToFile();
                    break;
                case 5:
                    // Exit
                    break;
                case 6:
                    // Delete file
                    journal.DeleteFile();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}